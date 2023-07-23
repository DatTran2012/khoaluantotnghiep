import 'package:flutter/material.dart';
import 'package:expandable_bottom_bar/expandable_bottom_bar.dart';
import 'package:banner_carousel/banner_carousel.dart';
import 'package:flutter/rendering.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/controller/order_controller.dart';
import 'package:flutter_fastfood_app/model/table.dart';
import 'package:flutter_fastfood_app/screen/table_screen.dart';
import 'package:flutter_fastfood_app/widget/menu_widget.dart';
import 'package:flutter_fastfood_app/widget/order_list_widget.dart';
import 'package:get/get.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;

class OrderScreen extends StatelessWidget {
  final orderController = Get.put(MyController());
  final TableModel tableModel;
  final int idHoaDon;
  OrderScreen({Key? key, required this.tableModel, required this.idHoaDon}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          backgroundColor: color.orangeMain,
          foregroundColor: Colors.white,
          title: const Text('ORDER'),
          centerTitle: true,
          leading: IconButton(
              icon: const Icon(Icons.close_rounded),
              onPressed: () {
                showAlertDialog(context, tableModel);
              }),
        ),
        backgroundColor: Theme.of(context).canvasColor,
        extendBody: true,
        floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
        floatingActionButton: GestureDetector(
          onVerticalDragUpdate: DefaultBottomBarController.of(context).onDrag,
          onVerticalDragEnd: DefaultBottomBarController.of(context).onDragEnd,
          child: FloatingActionButton.extended(
            label: AnimatedBuilder(
              animation: DefaultBottomBarController.of(context).state,
              builder: (context, child) => Row(
                children: [
                  Text(
                    DefaultBottomBarController.of(context).isOpen
                        ? "Món ăn của bạn"
                        : "Món ăn của bạn",
                  ),
                  const SizedBox(width: 4.0),
                  AnimatedBuilder(
                    animation: DefaultBottomBarController.of(context).state,
                    builder: (context, child) => Transform(
                      alignment: Alignment.center,
                      transform: Matrix4.diagonal3Values(
                        1,
                        DefaultBottomBarController.of(context).state.value * 2 -
                            1,
                        1,
                      ),
                      child: child,
                    ),
                    child: const RotatedBox(
                      quarterTurns: 1,
                      child: Icon(
                        Icons.chevron_right,
                        size: 20,
                      ),
                    ),
                  ),
                ],
              ),
            ),
            elevation: 2,
            backgroundColor: const Color(0xffa31806),
            foregroundColor: Colors.white,
            onPressed: () => DefaultBottomBarController.of(context).swap(),
          ),
        ),
        bottomNavigationBar: BottomExpandableAppBar(
          horizontalMargin: 16,
          shape: const AutomaticNotchedShape(
              RoundedRectangleBorder(), StadiumBorder(side: BorderSide())),
          expandedBackColor: const Color(0xfffeefd1),
          //ORDER LIST
          expandedBody: OrderListWidget(idban: tableModel.id, idhoadon: idHoaDon,),

          bottomAppBarBody: Container(
            color: color.orangeMain,
            child: Padding(
              padding: const EdgeInsets.all(8.0),
              child: Row(
                mainAxisSize: MainAxisSize.max,
                children: <Widget>[
                  Expanded(
                    child: Image.asset(
                      'assets/logored.png',
                      width: 32,
                      height: 32,
                      fit: BoxFit.cover,
                    ),
                  ),
                  const Spacer(
                    flex: 2,
                  ),
                  Expanded(
                    child: Text(
                      'Bàn ${tableModel.id}',
                      textAlign: TextAlign.center,
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
        body: menu());
  }

  menu() {
    return Stack(
      children: <Widget>[
        Padding(
          padding: const EdgeInsets.only(top: 8.0),
          child: BannerCarousel(
            banners: BannerImages.listBanners,
            customizedIndicators: const IndicatorModel.animation(
                width: 20, height: 5, spaceBetween: 2, widthAnimation: 50),
            height: 120,
            activeColor: Colors.amberAccent,
            disableColor: Colors.white,
            animation: true,
            borderRadius: 10,
            width: 370,
            indicatorBottom: false,
          ),
        ),
        const Padding(
          padding: EdgeInsets.only(top: 140.0),
          child: MyTabbar(),
        ), // const MyTabbar(), Container(color: Colors.purple,),
      ],
    );
  }
}

//TABBAR
class MyTabbar extends StatefulWidget {
  const MyTabbar({Key? key}) : super(key: key);

  @override
  _MyTabbarState createState() => _MyTabbarState();
}

class _MyTabbarState extends State<MyTabbar> with TickerProviderStateMixin {
  late TabController _tabcontroller;

  @override
  void initState() {
    super.initState();
    _tabcontroller = TabController(vsync: this, length: 5);
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        SizedBox(
          height: 40,
          child: TabBar(
            indicator: const BoxDecoration(
                color: Color(0xfffaad17),
                borderRadius: BorderRadius.only(
                    topRight: Radius.circular(30),
                    bottomLeft: Radius.circular(30))),
            isScrollable: true,
            unselectedLabelColor: Colors.black,
            labelColor: Colors.white,
            controller: _tabcontroller,
            tabs: <Widget>[
              Tab(
                child: Row(
                  children: <Widget>[
                    Image.asset(
                      'assets/fastfood.png',
                      width: 24,
                      height: 24,
                    ),
                    const Text(
                      'Tất cả',
                      style: TextStyle(fontSize: 14),
                    )
                  ],
                ),
              ),
              Tab(
                child: Row(
                  children: <Widget>[
                    Image.asset(
                      'assets/chicken.png',
                      width: 24,
                      height: 24,
                    ),
                    const Text(
                      'Gà',
                      style: TextStyle(fontSize: 14),
                    )
                  ],
                ),
              ),
              Tab(
                child: Row(
                  children: <Widget>[
                    Image.asset(
                      'assets/combo.png',
                      width: 24,
                      height: 24,
                    ),
                    const Text(
                      'Combo',
                      style: TextStyle(fontSize: 14),
                    )
                  ],
                ),
              ),
              Tab(
                child: Row(
                  children: <Widget>[
                    Image.asset(
                      'assets/hamburger.png',
                      width: 24,
                      height: 24,
                    ),
                    const Text(
                      'Burger',
                      style: TextStyle(fontSize: 14),
                    )
                  ],
                ),
              ),
              Tab(
                child: Row(
                  children: <Widget>[
                    Image.asset(
                      'assets/tart.png',
                      width: 24,
                      height: 24,
                    ),
                    const Text(
                      'Ăn kèm',
                      style: TextStyle(fontSize: 14),
                    )
                  ],
                ),
              ),
            ],
          ),
        ),
        Expanded(
          flex: 2,
          child: TabBarView(
            controller: _tabcontroller,
            children: <Widget>[
              const MenuWidget(),
              Container(
                color: Colors.green,
                height: 30,
              ),
              Container(
                color: Colors.yellow,
                height: 30,
              ),
              Container(
                color: Colors.blue,
                height: 30,
              ),
              Container(
                color: Colors.purple,
                height: 30,
              ),
            ],
          ),
        )
      ],
    );
  }
}

//BANNER
class BannerImages {
  static const String banner1 = 'assets/banner1.jpg';
  static const String banner2 = 'assets/banner2.jpg';
  static const String banner3 = 'assets/banner1.jpg';
  static const String banner4 = 'assets/banner2.jpg';
    
  static List<BannerModel> listBanners = [
    BannerModel(imagePath: banner1, id: "1"),
    BannerModel(imagePath: banner2, id: "2"),
    BannerModel(imagePath: banner3, id: "3"),
    BannerModel(imagePath: banner4, id: "4"),
  ];
}

showAlertDialog(BuildContext context, TableModel table) {
  // Create AlertDialog
  AlertDialog alert = AlertDialog(
    title: const Text("Cảnh báo !"),
    content: const Text("Bạn muốn hủy order ?"),
    actions: <Widget>[
      TextButton(
          child: const Text(
            "CÓ",
            style: TextStyle(
                color: Colors.green, fontSize: 18, fontWeight: FontWeight.bold),
          ),
          onPressed: () {
            APIService.updateTableStatus(table, 0).then((value) {
              Get.reset();
              Navigator.of(context, rootNavigator: true).pop(); //đóng dialog
              Navigator.pushReplacement(context,
                  MaterialPageRoute(builder: (context) => const TableScreen()));
            });
          }),
      TextButton(
          child: const Text(
            "KHÔNG",
            style: TextStyle(
                color: Colors.grey, fontSize: 18, fontWeight: FontWeight.bold),
          ),
          onPressed: () => Navigator.of(context, rootNavigator: true).pop())
    ],
  );

  // show the dialog
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return alert;
    },
  );
}
