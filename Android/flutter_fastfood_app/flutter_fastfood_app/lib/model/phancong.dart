// To parse this JSON data, do
//
//     final phanCong = phanCongFromMap(jsonString);

import 'dart:convert';

List<PhanCong> phanCongFromMap(String str) => List<PhanCong>.from(json.decode(str).map((x) => PhanCong.fromMap(x)));

String phanCongToMap(List<PhanCong> data) => json.encode(List<dynamic>.from(data.map((x) => x.toMap())));

class PhanCong {
    PhanCong({
        required this.idnv,
        required this.caLam,
        required this.ngayLam,
        required this.diemDanh,
    });

    String idnv;
    int caLam;
    DateTime ngayLam;
    String diemDanh;

    factory PhanCong.fromMap(Map<String, dynamic> json) => PhanCong(
        idnv: json["IDNV"],
        caLam: json["CaLam"],
        ngayLam: DateTime.parse(json["NgayLam"]),
        diemDanh: json["DiemDanh"],
    );

    Map<String, dynamic> toMap() => {
        "IDNV": idnv,
        "CaLam": caLam,
        "NgayLam": ngayLam.toIso8601String(),
        "DiemDanh": diemDanh,
    };
}
