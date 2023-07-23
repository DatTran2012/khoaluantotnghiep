import 'package:flutter/material.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/controller/order_controller.dart';
import 'package:flutter_fastfood_app/model/food.dart';
import 'package:get/get.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;

class MenuWidget extends StatelessWidget {
  const MenuWidget({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: APIService.fetchFoods(),
      builder: (BuildContext context, AsyncSnapshot snapshot) {
        if (snapshot.hasData) {
          return ListView.builder(
              itemCount: snapshot.data.length,
              itemBuilder: (BuildContext context, int index) {
                return MenuItem(food: snapshot.data[index]);
              });
        } else {
          return const Center(
            child: CircularProgressIndicator(),
          );
        }
      },
    );
  }
}

class MenuItem extends StatelessWidget {
  final orderController = Get.put(MyController());
  final Food food;
  MenuItem({Key? key, required this.food}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Card(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10),
      ),
      elevation: 5.0,
      child: Row(
        children: <Widget>[
          Expanded(
              flex: 1,
              child: Image.network(
                food.anh,
                width: 110,
                height: 110,
                fit: BoxFit.cover,
              )),
          Expanded(
            flex: 2,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(
                        flex: 2,
                        child: Text(
                          food.tenMa,
                          style: const TextStyle(
                              color: color.orangeMain,
                              fontWeight: FontWeight.bold),
                        )),
                    Expanded(
                      flex: 2,
                      child: Stack(
                        children: [
                          Image.asset(
                            'assets/price.png',
                            width: 120,
                            height: 70,
                            fit: BoxFit.cover,
                          ),
                          showPrice(food.giaBan, food.giaKhuyenMai),
                        ],
                      ),
                    ),
                  ],
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(4.0, 4.0, 0, 6.0),
                  child: Row(
                    children: [
                      Expanded(
                          flex: 4,
                          child: Text(food.moTa,
                              style: const TextStyle(
                                color: Colors.grey,
                                fontSize: 12,
                              ))),
                      Expanded(
                        flex: 1,
                        child: IconButton(
                            onPressed: () {
                              orderController.addFood(food);
                            }, 
                            icon: const Icon(Icons.post_add)),
                      )
                    ],
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }

  showPrice(int giaban, int giakm) {
    if (giaban == giakm) {
      return Padding(
        padding: const EdgeInsets.fromLTRB(55, 25, 0, 0),
        child: Text(
          '$giaban',
          style:
              const TextStyle(color: Colors.white, fontWeight: FontWeight.bold),
        ),
      );
    } else {
      return Padding(
        padding: const EdgeInsets.fromLTRB(55, 16, 0, 0),
        child: Column(
          children: [
            Text(
              '$giaban',
              style: const TextStyle(
                  color: Colors.white, decoration: TextDecoration.lineThrough),
            ),
            Text(
              '$giakm',
              style: const TextStyle(
                  color: Colors.white, fontWeight: FontWeight.bold),
            ),
          ],
        ),
      );
    }
  }
}
