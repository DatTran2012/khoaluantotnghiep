import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/model/user.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;
import 'package:flutter_fastfood_app/screen/login_screen.dart';

class PassDialog extends StatelessWidget {
  final User user;
  PassDialog({Key? key, required this.user}) : super(key: key);

  final txtPassCu = TextEditingController();
  final txtPassMoi = TextEditingController();
  final txtRePassMoi = TextEditingController();

  final _formKey = GlobalKey<FormState>();
  @override
  Widget build(BuildContext context) {
    return Dialog(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
      child: SizedBox(
        height: 420,
        child: SingleChildScrollView(
          child: Column(
            children: <Widget>[
              ClipRRect(
                borderRadius: const BorderRadius.only(
                  topLeft: Radius.circular(15.0),
                  topRight: Radius.circular(15.0),
                ),
                child: Container(
                  width: 300,
                  color: color.orangeMain,
                  child: const Padding(
                    padding: EdgeInsets.all(16.0),
                    child: Text(
                      'Đổi mật khẩu',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: TextFormField(
                  controller: txtPassCu,
                  decoration: const InputDecoration(
                    label: Text('Mật khẩu cũ'),
                    border: OutlineInputBorder(),
                  ),
                  validator: (text) {
                    if (text!.isEmpty) {
                      return 'Không được bỏ trống';
                    }
                    return null;
                  },
                ),
              ),
              Form(
                  key: _formKey,
                  child: Column(
                    children: <Widget>[
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: TextFormField(
                          controller: txtPassMoi,
                          decoration: const InputDecoration(
                            label: Text('Mật khẩu mới'),
                            border: OutlineInputBorder(),
                          ),
                          validator: (text) {
                            if (text!.isEmpty) {
                              return 'Không được bỏ trống';
                            }
                            if (!(text.length == 8)) {
                              return 'Mật khẩu tối đa 8 kí tự';
                            }
                            if (!(text.contains('@'))) {
                              return "Mật khẩu cần có kí tự @";
                            }
                            return null;
                          },
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: TextFormField(
                          controller: txtRePassMoi,
                          decoration: const InputDecoration(
                            label: Text('Nhập lại mật khẩu mới'),
                            border: OutlineInputBorder(),
                          ),
                          validator: (text) {
                            if (text!.isEmpty) {
                              return 'Không được bỏ trống';
                            }
                            if (txtPassMoi.text != txtRePassMoi.text) {
                              return "Xác nhận mật khẩu không khớp";
                            }
                            return null;
                          },
                        ),
                      ),
                      ElevatedButton(
                        style: ElevatedButton.styleFrom(
                          primary: color.redMain,
                        ),
                        child: const Text('XÁC NHẬN'),
                        onPressed: () async {
                          if (_formKey.currentState!.validate()) {
                            EasyLoading.show(status: 'Vui lòng chờ..');
                            int statuscode;
                            if (txtPassCu.text == user.matKhau) {
                              statuscode = (await APIService.updatePass(user, txtPassMoi.text))!;
                              if (statuscode == 200) {
                                EasyLoading.showSuccess('Thành công/nVui lòng đang nhập lại');
                                Navigator.pushReplacement(context, MaterialPageRoute(builder: (context) => const LoginScreen()));
                              }
                            } else {
                              print('Mật khẩu cũ không đúng!');
                              print(user.matKhau);
                              print(txtPassCu.text);
                              Navigator.of(context, rootNavigator: true).pop();
                              EasyLoading.showToast('Mật khẩu cũ không đúng !\nVui lòng thử lại.');
                            }
                          }
                        },
                      )
                    ],
                  )),
            ],
          ),
        ),
      ),
    );
  }

  showLoaderDialog(BuildContext context) {
    AlertDialog alert = AlertDialog(
      content: Row(
        children: [
          const CircularProgressIndicator(),
          Container(
              margin: const EdgeInsets.only(left: 7),
              child: const Text("Loading...")),
        ],
      ),
    );
    showDialog(
      barrierDismissible: false,
      context: context,
      builder: (BuildContext context) {
        return alert;
      },
    );
  }
}
