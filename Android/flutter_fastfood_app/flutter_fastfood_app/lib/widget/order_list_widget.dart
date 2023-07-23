import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/controller/order_controller.dart';
import 'package:flutter_fastfood_app/model/cthd.dart';
import 'package:flutter_fastfood_app/model/food.dart';
import 'package:flutter_fastfood_app/model/hoadon.dart';
import 'package:flutter_fastfood_app/screen/table_screen.dart';
import 'package:flutter_fastfood_app/share/sharepreference.dart';
import 'package:get/get.dart';
import 'package:intl/intl.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;

class OrderListWidget extends StatelessWidget {
  final int idban;
  final int idhoadon;
  const OrderListWidget({Key? key, required this.idban, required this.idhoadon})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: <Widget>[
        Expanded(
          flex: 4,
          child: Padding(
            padding: const EdgeInsets.fromLTRB(16, 40, 16, 12),
            child: OrderListView(),
          ),
        ),
        Expanded(
            flex: 1,
            child: Padding(
              padding: const EdgeInsets.only(bottom: 64.0),
              child: OrderListTotalCard(
                idban: idban,
                idhoadon: idhoadon,
              ),
            )),
      ],
    );
  }
}

class OrderListView extends StatelessWidget {
  final MyController myController = Get.find();
  OrderListView({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Obx(
      () => ListView.builder(
          itemCount: myController.foods.length,
          itemBuilder: (context, index) {
            return OrderListItem(
                orderController: myController,
                food: myController.foods.keys.toList()[index],
                quanlity: myController.foods.values.toList()[index],
                index: index);
          }),
    );
  }
}

class OrderListItem extends StatelessWidget {
  final MyController orderController;
  final Food food;
  final int quanlity;
  final int index;
  const OrderListItem(
      {Key? key,
      required this.orderController,
      required this.food,
      required this.quanlity,
      required this.index})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Row(
      children: <Widget>[
        Padding(
          padding: const EdgeInsets.only(bottom: 8.0),
          child:
              CircleAvatar(radius: 35, backgroundImage: NetworkImage(food.anh)),
        ),
        Padding(
          padding: const EdgeInsets.only(left: 4.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              SizedBox(
                  width: 180,
                  child: Text(
                    food.tenMa,
                    overflow: TextOverflow.ellipsis,
                    maxLines: 2,
                  )),
              Row(
                children: <Widget>[
                  Row(
                    children: <Widget>[
                      IconButton(
                          onPressed: () {
                            orderController.removeFood(food);
                          },
                          icon: const Icon(Icons.remove_circle_rounded)),
                      Text('$quanlity'),
                      IconButton(
                          onPressed: () {
                            orderController.addFood(food);
                          },
                          icon: const Icon(Icons.add_circle_rounded))
                    ],
                  ),
                  Padding(
                    padding: const EdgeInsets.only(left: 60.0),
                    child: Text(
                      '${food.giaKhuyenMai * quanlity}',
                      style: const TextStyle(
                        color: Color(0xffa31806),
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  )
                ],
              ),
            ],
          ),
        ),
      ],
    );
  }
}

class OrderListTotalCard extends StatelessWidget {
  final int idban;
  final int idhoadon;
  final MyController orderController = Get.find();
  OrderListTotalCard({Key? key, required this.idban, required this.idhoadon})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Obx(
      () => Card(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: <Widget>[
            const Padding(
              padding: EdgeInsets.only(left: 12.0),
              child: Text('Tổng cộng: '),
            ),
            Text('${orderController.total}',
                style: const TextStyle(
                    fontWeight: FontWeight.bold, color: Colors.red)),
            Row(
              children: [
                const Text('ORDER'),
                Padding(
                  padding: const EdgeInsets.fromLTRB(12, 0, 12, 0),
                  child: ElevatedButton(
                    child: const Icon(
                      Icons.arrow_forward,
                      color: Colors.white,
                    ),
                    style: ElevatedButton.styleFrom(
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(45)),
                        padding: const EdgeInsets.all(16.0),
                        minimumSize: const Size(10, 10),
                        primary: color.redMain),
                    onPressed: () {
                      if (idhoadon == 0) {
                        createHoaDon();
                      } else {
                        orderAdditional();
                      }
                      EasyLoading.showSuccess('Order thành công!');
                      Navigator.pushReplacement(
                          context,
                          MaterialPageRoute(
                              builder: (context) => TableScreen()));
                    },
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  Future<List<HoaDon>> getHoaDon() {
    return APIService.fetchHDs();
  }

  void createHoaDon() async {
    EasyLoading.show(status: 'Đang xử lý...');
    List<HoaDon> hoadons = await getHoaDon();

    //NgayLap
    DateFormat dateformat = DateFormat("yyyy-MM-ddTHH:mm:ss");
    String str = dateformat.format(DateTime.now());
    DateTime ngayLap = dateformat.parse(str);

    //Id nhan vien
    String idnv = MySharePreference().getUserName();
    print(idnv);

    //Tạo hóa đơn
    APIService.createHoaDon(hoadons.length + 1, ngayLap, idnv, idban).then((value) {
      //Thêm chi tiết hóa đơn
      List<CTHD> listCTHD = [];
      for (int i = 0; i < orderController.foods.length; i++) {
        listCTHD.add(CTHD(
            idHoaDon: hoadons.length + 1,
            idMonAn: orderController.foods.keys.toList()[i].id,
            soLuong: orderController.foods.values.toList()[i],
            giaBan: orderController.foods.keys.toList()[i].giaKhuyenMai,
            thanhTien: orderController.foods.keys.toList()[i].giaKhuyenMai *
                       orderController.foods.values.toList()[i]));
      }
      APIService.insertListCTHD(listCTHD).then((value) {
        //Update số lượng nguyên liệu tồn
      APIService.updateSLNguyenLieu(listCTHD);
      });
    });

    //Xóa dữ liệu trong controller
    Get.reset();
  }

  void orderAdditional() async {
    EasyLoading.show(status: 'Đang xử lý...');
    //Thêm chi tiết hóa đơn
    List<CTHD> listCTHD = [];
    for (int i = 0; i < orderController.foods.length; i++) {
      listCTHD.add(CTHD(
          idHoaDon: idhoadon,
          idMonAn: orderController.foods.keys.toList()[i].id,
          soLuong: orderController.foods.values.toList()[i],
          giaBan: orderController.foods.keys.toList()[i].giaKhuyenMai,
          thanhTien: orderController.foods.keys.toList()[i].giaKhuyenMai *
              orderController.foods.values.toList()[i]));
    }
    APIService.insertListCTHD(listCTHD);

    //Update số lượng nguyên liệu tồn
    APIService.updateSLNguyenLieu(listCTHD);

    //Xóa dữ liệu trong controller
    Get.reset();
  }
}
