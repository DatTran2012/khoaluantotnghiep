import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/model/user.dart';
import 'package:flutter_fastfood_app/screen/home_screen.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;
import 'package:flutter_fastfood_app/share/sharepreference.dart';

class LoginScreen extends StatefulWidget {
  const LoginScreen({Key? key}) : super(key: key);

  @override
  _LoginScreenState createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  final txtDanNhapTextController = TextEditingController();
  final txtMatKhauTextController = TextEditingController();
  bool isLoading = false;
  bool _isShow = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        resizeToAvoidBottomInset: false,
        body: Container(
          width: double.infinity,
          decoration: BoxDecoration(
              gradient: LinearGradient(begin: Alignment.topCenter, colors: [
            Colors.orange.shade900,
            Colors.orange.shade800,
            Colors.orange.shade400
          ])),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              const Padding(
                padding: EdgeInsets.fromLTRB(20, 170, 16, 8),
                child: Text(
                  'Đăng nhập',
                  style: TextStyle(fontSize: 32, color: Colors.white),
                ),
              ),
              const SizedBox(
                height: 10,
              ),
              const Padding(
                padding: EdgeInsets.fromLTRB(20, 0, 16, 16),
                child: Text(
                  'Chào mừng trở lại',
                  style: TextStyle(fontSize: 18, color: Colors.white),
                ),
              ),
              Expanded(
                child: Container(
                  margin: const EdgeInsets.fromLTRB(16, 24, 16, 32),
                  decoration: const BoxDecoration(
                      color: Colors.white,
                      borderRadius: BorderRadius.all(Radius.circular(40))),
                  child: Center(
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        const SizedBox(height: 20),
                        SizedBox(
                          width: 300,
                          child: Material(
                            elevation: 5.0,
                            color: color.orangeMain,
                            borderRadius:
                                const BorderRadius.all(Radius.circular(45.0)),
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                const Padding(
                                  padding: EdgeInsets.only(left: 15),
                                  child: Icon(
                                    Icons.person,
                                    color: Colors.white,
                                  ),
                                ),
                                SizedBox(
                                  width: 250,
                                  child: TextField(
                                    controller: txtDanNhapTextController,
                                    decoration: const InputDecoration(
                                      border: OutlineInputBorder(
                                        borderRadius: BorderRadius.all(
                                            Radius.circular(45.0)),
                                        borderSide: BorderSide(
                                          width: 0,
                                          style: BorderStyle.none,
                                        ),
                                      ),
                                      hintText: 'Nhân viên',
                                      fillColor: Colors.white,
                                      filled: true,
                                    ),
                                    style: const TextStyle(
                                        fontSize: 14.0, color: Colors.black),
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ),
                        const SizedBox(
                          height: 40,
                        ),
                        SizedBox(
                          width: 300,
                          child: Material(
                            elevation: 5.0,
                            color: color.orangeMain,
                            borderRadius:
                                const BorderRadius.all(Radius.circular(45.0)),
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                const Padding(
                                  padding: EdgeInsets.only(left: 15),
                                  child: Icon(
                                    Icons.vpn_key,
                                    color: Colors.white,
                                  ),
                                ),
                                SizedBox(
                                  width: 250,
                                  child: TextField(
                                    controller: txtMatKhauTextController,
                                    obscureText: !_isShow,
                                    decoration: InputDecoration(
                                      suffixIcon: IconButton(
                                          onPressed: () {
                                            setState(() {
                                              _isShow = !_isShow;
                                            });
                                          },
                                          icon: _isShow
                                              ? const Icon(Icons.visibility_off)
                                              : const Icon(Icons.visibility)),
                                      border: const OutlineInputBorder(
                                        borderRadius: BorderRadius.all(
                                            Radius.circular(45.0)),
                                        borderSide: BorderSide(
                                          width: 0,
                                          style: BorderStyle.none,
                                        ),
                                      ),
                                      hintText: 'Mật khẩu',
                                      fillColor: Colors.white,
                                      filled: true,
                                    ),
                                    style: const TextStyle(
                                        fontSize: 14.0, color: Colors.black),
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ),
                        const SizedBox(
                          height: 50,
                        ),
                        Container(
                          decoration: BoxDecoration(
                              borderRadius: const BorderRadius.all(Radius.circular(32)),
                              gradient: LinearGradient(
                                  begin: Alignment.topCenter,
                                  colors: [
                                    Colors.orange.shade900,
                                    Colors.orange.shade800,
                                    Colors.orange.shade400
                                  ])),
                          width: 300,
                          child: ElevatedButton(
                            child: const Text(
                              'ĐĂNG NHẬP',
                              style: TextStyle(color: Colors.white),
                            ),
                            style: ElevatedButton.styleFrom(
                                shape: RoundedRectangleBorder(
                                    borderRadius: BorderRadius.circular(32)),
                                elevation: 5.0,
                                fixedSize: const Size(80, 55),
                                primary: Colors.transparent,
                                onSurface: Colors.transparent,
                                shadowColor: Colors.transparent),
                            onPressed: login,
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ),
            ],
          ),
        ));
  }

  Future<User> getData() {
    return APIService().fetchUsers(txtDanNhapTextController.text);
  }

  void login() async {
    EasyLoading.show(status: 'Vui lòng chờ...');
    User user = await getData();
    if (user.matKhau == txtMatKhauTextController.text) {
      EasyLoading.dismiss();
      MySharePreference().setUserName(user.id);
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(
          builder: (context) => HomeScreen(userprofile: user),
        ),
      );
    } else {
      EasyLoading.dismiss();
      EasyLoading.showToast('Mật khẩu không đúng !\nVui lòng thử lại.');
    }
  }
}
