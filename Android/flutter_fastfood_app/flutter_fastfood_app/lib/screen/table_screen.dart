import 'package:expandable_bottom_bar/expandable_bottom_bar.dart';
import 'package:flutter/material.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/dialog/my_alert_dialog.dart';
import 'package:flutter_fastfood_app/model/hoadon.dart';
import 'package:flutter_fastfood_app/screen/order_screen.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;
import 'package:flutter_fastfood_app/res/strings.dart' as string;

class TableScreen extends StatefulWidget {
  const TableScreen({Key? key}) : super(key: key);

  @override
  _TableScreenState createState() => _TableScreenState();
}

class _TableScreenState extends State<TableScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: color.orangeMain,
        foregroundColor: Colors.white,
        title: const Text('DANH SÁCH BÀN'),
        centerTitle: true,
      ),
      body: Column(
        children: <Widget>[
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: SizedBox(
              height: 60,
              child: Card(
                elevation: 5.0,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: <Widget>[
                    Row(
                      children: <Widget>[
                        const Text('${string.banTrong}: '),
                        FutureBuilder(
                          future: APIService.fetchCountTablesNull(),
                          builder:
                              (BuildContext context, AsyncSnapshot snapshot) {
                            if (snapshot.hasData) {
                              return Text(
                                '${snapshot.data.length}',
                              );
                            }
                            return const Text('--');
                          },
                        ),
                      ],
                    ),
                    Row(
                      children: <Widget>[
                        const Text('${string.coKhach}:  '),
                        FutureBuilder(
                          future: APIService.fetchCountTables(),
                          builder:
                              (BuildContext context, AsyncSnapshot snapshot) {
                            if (snapshot.hasData) {
                              return Text(
                                '${snapshot.data.length}',
                              );
                            }
                            return const Text('--');
                          },
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ),
          Expanded(
            child: FutureBuilder(
                future: APIService.fetchTables(),
                builder: (BuildContext context, AsyncSnapshot snapshot) {
                  if (snapshot.hasData) {
                    return GridView.builder(
                      gridDelegate:
                          const SliverGridDelegateWithFixedCrossAxisCount(
                              crossAxisCount: 3,
                              crossAxisSpacing: 4.0,
                              mainAxisSpacing: 4.0),
                      itemCount: snapshot.data.length,
                      itemBuilder: (BuildContext context, int index) {
                        if (snapshot.data[index].tinhTrang == 1) {
                          return GestureDetector(
                            child: Card(
                              child: Column(
                                children: <Widget>[
                                  Image.asset(
                                    'assets/chair.png',
                                    width: 64,
                                    height: 64,
                                  ),
                                  Text(
                                    '${snapshot.data[index].id}',
                                    style: const TextStyle(
                                        fontSize: 18,
                                        fontWeight: FontWeight.bold),
                                  ),
                                ],
                              ),
                            ),
                            onTap: () async {
                              HoaDon hd = await APIService()
                                  .fetchHDByIDBan(snapshot.data[index].id);
                              print(snapshot.data[index].id.toString());
                              Navigator.pushReplacement(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) =>
                                        DefaultBottomBarController(
                                      child: OrderScreen(
                                        tableModel: snapshot.data[index],
                                        idHoaDon: hd.id, //mã tạm thời
                                      ),
                                    ),
                                  ));
                            },
                            onLongPress: () async => showDialog<String>(
                              context: context,
                              builder: (BuildContext context) => MyAlertDialog(
                                  title: 'Xác nhận',
                                  content:
                                      'Bạn muốn yêu cầu thanh toán phải không ?',
                                  btnLeft: 'Hủy',
                                  btnRight: 'Yêu Cầu',
                                  btnLeftClick: () =>
                                      Navigator.pop(context, 'Cancel'),
                                  btnRightClick: () async {
                                    HoaDon hd = await APIService()
                                        .fetchHDByIDBan(
                                            snapshot.data[index].id);
                                    APIService.updateHoaDon(hd);
                                    APIService.updateTableStatus(
                                        snapshot.data[index], 2);
                                  }),
                            ),
                          );
                        } else if (snapshot.data[index].tinhTrang == 2) {
                          // tt 2: yêu cầu thanh toán
                          return GestureDetector(
                            child: Card(
                              child: Column(
                                children: <Widget>[
                                  Image.asset(
                                    'assets/payment.png',
                                    width: 64,
                                    height: 64,
                                  ),
                                  Text(
                                    '${snapshot.data[index].id}',
                                    style: const TextStyle(
                                        fontSize: 18,
                                        fontWeight: FontWeight.bold),
                                  ),
                                ],
                              ),
                            ),
                          );
                        } else {
                          return GestureDetector(
                            child: Card(
                              elevation: 5.0,
                              child: Column(
                                children: <Widget>[
                                  Image.asset(
                                    'assets/nochair.png',
                                    width: 64,
                                    height: 64,
                                  ),
                                  Text(
                                    '${snapshot.data[index].id}',
                                    style: const TextStyle(
                                        fontSize: 18,
                                        fontWeight: FontWeight.bold),
                                  ),
                                ],
                              ),
                            ),
                            onTap: () {
                              APIService.updateTableStatus(
                                  snapshot.data[index], 1);
                              Navigator.pushReplacement(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) =>
                                        DefaultBottomBarController(
                                      child: OrderScreen(
                                        tableModel: snapshot.data[index],
                                        idHoaDon: 0,//mã tạm thời
                                      ),
                                    ),
                                  ));
                            },
                          );
                        }
                      },
                    );
                  } else {
                    return const Center(
                      child: CircularProgressIndicator(),
                    );
                  }
                }
            ),
          ),
        ],
      ),
    );
  }
}
