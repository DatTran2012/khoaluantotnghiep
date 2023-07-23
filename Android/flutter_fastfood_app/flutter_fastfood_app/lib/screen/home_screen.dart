import 'package:flutter/material.dart';

import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/dialog/my_alert_dialog.dart';
import 'package:flutter_fastfood_app/dialog/password_dialog.dart';
import 'package:flutter_fastfood_app/dialog/profile_dialog.dart';
import 'package:flutter_fastfood_app/model/user.dart';
import 'package:flutter_fastfood_app/screen/attendance_screen.dart';
import 'package:flutter_fastfood_app/screen/login_screen.dart';
import 'package:flutter_fastfood_app/screen/schedule_screen.dart';
import 'package:flutter_fastfood_app/screen/table_screen.dart';

import 'package:flutter_fastfood_app/res/colors.dart' as color;
import 'package:flutter_fastfood_app/res/strings.dart' as string;
import 'package:flutter_fastfood_app/res/path_image.dart' as path_img;
import 'package:flutter_fastfood_app/share/sharepreference.dart';
import 'package:flutter_fastfood_app/widget/home/home_button.dart';

class HomeScreen extends StatelessWidget {
  final User userprofile;
  const HomeScreen({Key? key, required this.userprofile}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Stack(
              children: <Widget>[
                Material(
                  elevation: 5.0,
                  child: Container(
                    width: MediaQuery.of(context).size.width,
                    height: 170,
                    color: color.orangeMain,
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(12, 50, 12, 0),
                  child: Row(
                    children: <Widget>[
                      CircleAvatar(
                        radius: 50,
                        backgroundImage: NetworkImage(userprofile.anh),
                      ),
                      Padding(
                        padding: const EdgeInsets.all(10.0),
                        child: Container(
                          width: 2,
                          height: 60,
                          color: Colors.white,
                        ),
                      ),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          Text(
                            userprofile.tenNv,
                            style: const TextStyle(
                                color: Colors.white,
                                fontSize: 18,
                                fontWeight: FontWeight.bold),
                          ),
                          const Padding(
                            padding: EdgeInsets.only(top: 12.0),
                            child: Text(
                              string.nvOrder,
                              style: TextStyle(color: Colors.white),
                            ),
                          ),
                        ],
                      )
                    ],
                  ),
                ),
              ],
            ),
            Column(
              children: <Widget>[
                Padding(
                  padding: const EdgeInsets.fromLTRB(16, 8, 16, 0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: <Widget>[
                      HomeButton(
                          pathImg: path_img.icoBtnOrder,
                          btnClick: () => Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => const TableScreen())),
                          btnName: string.btnOrder),
                      HomeButton(
                          pathImg: path_img.icoBtnInfo,
                          btnClick: () => showDialog(
                              context: context,
                              builder: (BuildContext context) {
                                return DialogProfile(
                                  user: userprofile,
                                );
                              }),
                          btnName: string.btnInfo),
                    ],
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(16, 8, 16, 0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: <Widget>[
                      HomeButton(
                          pathImg: path_img.icoBtnSchedule,
                          btnClick: () => Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => ScheduleScreen(
                                        id: userprofile.id,
                                      ))),
                          btnName: string.btnSchedule),
                      HomeButton(
                          pathImg: path_img.icoBtnAttendace,
                          btnClick: () => Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => AttendanceScreen(
                                        id: userprofile.id,
                                      ))),
                          btnName: string.btnAttendance),
                    ],
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(16, 8, 16, 0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      HomeButton(
                          pathImg: path_img.icoBtnPass,
                          btnClick: () => showDialog(
                              context: context,
                              builder: (BuildContext context) =>
                                  PassDialog(user: userprofile)),
                          btnName: string.btnPass),
                      HomeButton(
                          pathImg: path_img.icoBtnLogout,
                          btnClick: () async => showDialog<String>(
                                context: context,
                                builder: (BuildContext context) =>
                                    MyAlertDialog(
                                        title: 'Xác nhận',
                                        content:
                                            'Bạn muốn đăng xuất phải không ?',
                                        btnLeft: 'Hủy',
                                        btnRight: 'Đăng Xuất',
                                        btnLeftClick: () =>
                                            Navigator.pop(context, 'Cancel'),
                                        btnRightClick: () async {
                                          MySharePreference.instance.clear();
                                          Navigator.pushReplacement(
                                              context,
                                              MaterialPageRoute(
                                                  builder: (context) =>
                                                      const LoginScreen()));
                                        }),
                              ),
                          btnName: string.btnLogout),
                    ],
                  ),
                )
              ],
            ),
          ],
        ),
      ),
    );
  }
}
