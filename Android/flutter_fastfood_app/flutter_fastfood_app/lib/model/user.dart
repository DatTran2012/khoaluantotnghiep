// To parse this JSON data, do
//
//     final user = userFromMap(jsonString);

import 'dart:convert';

User userFromJson(String str) => User.fromJson(json.decode(str));

String userToJson(User data) => json.encode(data.toJson());

class User {
  String id;
    String tenNv;
    DateTime ngaySinh;
    String gioiTinh;
    String diaChi;
    String sdt;
    String cmt;
    String anh;
    DateTime ngayVl;
    String matKhau;

  User({
        required this.id,
        required this.tenNv,
        required this.ngaySinh,
        required this.gioiTinh,
        required this.diaChi,
        required this.sdt,
        required this.cmt,
        required this.anh,
        required this.ngayVl,
        required this.matKhau,
    });

    factory User.fromJson(Map<String, dynamic> json) => User(
        id: json["ID"],
        tenNv: json["TenNV"],
        ngaySinh: DateTime.parse(json["NgaySinh"]),
        gioiTinh: json["GioiTinh"],
        diaChi: json["DiaChi"],
        sdt: json["SDT"],
        cmt: json["CMT"],
        anh: json["Anh"],
        ngayVl: DateTime.parse(json["NgayVL"]),
        matKhau: json["MatKhau"],
    );

    Map<String, dynamic> toJson() => {
        "ID": id,
        "TenNV": tenNv,
        "NgaySinh": ngaySinh.toIso8601String(),
        "GioiTinh": gioiTinh,
        "DiaChi": diaChi,
        "SDT": sdt,
        "CMT": cmt,
        "Anh": anh,
        "NgayVL": ngayVl.toIso8601String(),
        "MatKhau": matKhau,
    };
  
}
