import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/model/phancong.dart';

import 'package:flutter_fastfood_app/res/colors.dart' as colors;

class AttendanceScreen extends StatefulWidget {
  final String id;
  const AttendanceScreen({Key? key, required this.id}) : super(key: key);

  @override
  _AttendanceScreenState createState() => _AttendanceScreenState();
}

class _AttendanceScreenState extends State<AttendanceScreen> {
  late String month, day;
  late List<PhanCong> dadiemdanh = [];

  Future<List<PhanCong>> listDDD() async {
    dadiemdanh = await APIService.countDaDiemDanh(widget.id);
    return dadiemdanh;
  }

  String _getMonth() {
    if (DateTime.now().month < 10) {
      return '0${DateTime.now().month}';
    } else {
      return '${DateTime.now().month}';
    }
  }

  String _getDay() {
    if (DateTime.now().month < 10) {
      return '0${DateTime.now().day}';
    } else {
      return '${DateTime.now().day}';
    }
  }

  @override
  void initState() {
    listDDD();
    super.initState();
  }


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: colors.orangeMain,
        foregroundColor: Colors.white,
        centerTitle: true,
        title: const Text('ĐIỂM DANH'),
      ),
      body: Column(
        children: <Widget>[
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: <Widget>[
                Stack(
                  children: <Widget>[
                    const Card(
                      elevation: 5,
                      child: SizedBox(
                        height: 150,
                        width: 130,
                      ),
                    ),
                    Card(
                      child: Container(
                        color: colors.redMain,
                        height: 50,
                        width: 130,
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(30, 18, 0, 18),
                      child: Text(
                        'Tháng ${DateTime.now().month}',
                        style:
                            const TextStyle(color: Colors.white, fontSize: 16),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(24, 60, 26, 18),
                      child: Text(
                        _getDay(),
                        style: const TextStyle(
                            fontSize: 64, fontWeight: FontWeight.bold),
                      ),
                    ),
                  ],
                ),
                Padding(
                  padding: const EdgeInsets.only(left: 18.0),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: <Widget>[
                      Container(
                        width: 180,
                        height: 50,
                        color: colors.redMain,
                        child: const Center(
                            child: Text(
                          'THỜI GIAN',
                          style: TextStyle(
                            color: Colors.white,
                          ),
                        )),
                      ),
                      const Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text(
                          'Ca 1:   07:00 - 12:00',
                          style: TextStyle(fontSize: 18),
                        ),
                      ),
                      const Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text(
                          'Ca 2:   12:00 - 17:00',
                          style: TextStyle(fontSize: 18),
                        ),
                      ),
                      const Padding(
                        padding: EdgeInsets.fromLTRB(0, 10, 0, 0),
                        child: Text(
                          'Ca 3:   17:00 - 22:00',
                          style: TextStyle(fontSize: 18),
                        ),
                      ),
                    ],
                  ),
                )
              ],
            ),
          ),
          Expanded(
            child: FutureBuilder(
                future: APIService.fetchPhanCongs(widget.id),
                builder: (BuildContext context, AsyncSnapshot snapshot) {
                  if (snapshot.connectionState == ConnectionState.waiting) {
                    return const Center(
                      child: CircularProgressIndicator(),
                    );
                  }
                  if (snapshot.hasData) {
                    if (snapshot.data.length == 0) {
                      return const Center(
                        child: Text('Không có lịch làm'),
                      );
                    } else {
                      return ListView.builder(
                          itemCount: snapshot.data.length,
                          itemBuilder: (context, index) {
                            return ListTile(
                              leading:
                                  statusIcon(snapshot.data[index].diemDanh),
                              title: Text('Ca ${snapshot.data[index].caLam}'),
                              trailing: diemDanhButton(snapshot.data[index]),
                              subtitle: Text(
                                  'Trạng thái: ${snapshot.data[index].diemDanh}'),
                            );
                          });
                    }
                  } else {
                    return const Center(
                      child: Text('fail'),
                    );
                  }
                }),
          ),
          
        ],
      ),
    );
  }

  diemDanhButton(PhanCong pc) {
    int hour = DateTime.now().hour;
    int minute = DateTime.now().minute;
    if (pc.diemDanh == 'Đã điểm danh') {
      return;
    } else if (pc.diemDanh.substring(0, 3) == 'Trễ') {
      return;
    } else if (pc.diemDanh == 'Vắng') {
      return;
    } else {
      return IconButton(
          onPressed: () {
            if (pc.caLam == 1) {
              if (hour == 7) {
                if ((minute - 0) <= 5) {
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Đã điểm danh');
                  APIService.updateDiemDanhStatus(phancong);
                } else {
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Trễ ${minute - 5}');
                  APIService.updateDiemDanhStatus(phancong);
                }
              } else {
                PhanCong phancong = PhanCong(
                    idnv: pc.idnv,
                    caLam: pc.caLam,
                    ngayLam: pc.ngayLam,
                    diemDanh: 'Trễ ${hour - 7}h$minute');
                APIService.updateDiemDanhStatus(phancong);
              }
            } else if (pc.caLam == 2) {
              if (hour == 12) {
                if ((minute - 0) <= 5) {
                  print('Đã điểm danh');
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Đã điểm danh');
                  APIService.updateDiemDanhStatus(phancong);
                } else {
                  print('Trễ ${minute - 5}p');
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Trễ ${minute - 5}p');
                  APIService.updateDiemDanhStatus(phancong);
                }
              } else {
                print('Trễ ${hour - 12}h${minute - 5}p');
                PhanCong phancong = PhanCong(
                    idnv: pc.idnv,
                    caLam: pc.caLam,
                    ngayLam: pc.ngayLam,
                    diemDanh: 'Trễ ${hour - 11}h$minute');
                APIService.updateDiemDanhStatus(phancong);
              }
            } else {
              if (hour == 17) {
                if ((minute - 0) <= 5) {
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Đã điểm danh'
                  );
                  APIService.updateDiemDanhStatus(phancong);
                } else {
                  PhanCong phancong = PhanCong(
                      idnv: pc.idnv,
                      caLam: pc.caLam,
                      ngayLam: pc.ngayLam,
                      diemDanh: 'Trễ ${minute - 5}');
                  APIService.updateDiemDanhStatus(phancong);
                }
              } else {
                PhanCong phancong = PhanCong(
                    idnv: pc.idnv,
                    caLam: pc.caLam,
                    ngayLam: pc.ngayLam,
                    diemDanh: 'Trễ ${hour - 17}h${minute}p');
                APIService.updateDiemDanhStatus(phancong);
              }
            }
            EasyLoading.showSuccess('Điểm danh thành công');
            Navigator.pop(context);
          },
          icon: const Icon(Icons.assignment_turned_in_sharp));
    }
  }

  statusIcon(String status) {
    if (status == 'Đã điểm danh') {
      return const Icon(
        Icons.check_circle_rounded,
        color: Colors.green,
      );
    } else if (status.substring(0, 3) == 'Trễ') {
      return const Icon(
        Icons.error_sharp,
        color: Colors.yellow,
      );
    } else if (status == 'Vắng') {
      return const Icon(
        Icons.remove_circle_rounded,
        color: Colors.red,
      );
    } else {
      return const Icon(Icons.circle);
    }
  }
}
