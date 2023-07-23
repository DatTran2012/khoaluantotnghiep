import 'package:flutter_fastfood_app/model/food.dart';
import 'package:get/get.dart';

class MyController extends GetxController {
  var _foods = {}.obs;
  var _total = 0.obs;

  void addFood(Food food) {
    if(_foods.containsKey(food)) {
      _foods[food] += 1;
      _total += food.giaKhuyenMai;
    } else {
      _foods[food] = 1;
      _total += food.giaKhuyenMai;
    }

    Get.snackbar('Bạn đã thêm', food.tenMa,
      snackPosition: SnackPosition.TOP,
      duration: const Duration(seconds: 1),
    );
  }

  get foods => _foods;

  void removeFood(Food food) {
    if (_foods.containsKey(food) && _foods[food] == 1) {
      _foods.removeWhere((key, value) => key == food);
      _total -= food.giaKhuyenMai;
    } else {
      _foods[food] -= 1;
      _total -= food.giaKhuyenMai;
    }
  }

  get total => _total;

  get foodSubTotal => _foods.entries
    .map((food) => food.key.giaKhuyenMai * food.value)
    .toList();

  // get total => _foods.entries
  //   .map((food) => food.key.giaKhuyenMai * food.value )
  //   .toList()
  //   .reduce((value, element) => value + element);
}