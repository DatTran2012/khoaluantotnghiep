// To parse this JSON data, do
//
//     final tableModel = tableModelFromMap(jsonString);

import 'dart:convert';

TableModel tableModelFromMap(String str) => TableModel.fromMap(json.decode(str));

String tableModelToMap(TableModel data) => json.encode(data.toMap());

class TableModel {
  int id;
  String viTri;
  int tinhTrang;
    TableModel({
        required this.id,
        required this.viTri,
        required this.tinhTrang,
    });

    factory TableModel.fromMap(Map<String, dynamic> json) => TableModel(
        id: json["ID"],
        viTri: json["ViTri"],
        tinhTrang: json["TinhTrang"],
    );

    Map<String, dynamic> toMap() => {
        "ID": id,
        "ViTri": viTri,
        "TinhTrang": tinhTrang,
    };
}
