import 'package:shared_preferences/shared_preferences.dart';

import 'dart:async' show Future;

enum SharePrefKey {
  username
}

class MySharePreference {

  static late final SharedPreferences instance;

  static Future<SharedPreferences> init() async =>
      instance = await SharedPreferences.getInstance();

  //USERNAME
  String getUserName() => instance.getString(SharePrefKey.username.toString()) ?? '';

  Future<bool> setUserName(String value) async =>
      await instance.setString(SharePrefKey.username.toString(), value);

}