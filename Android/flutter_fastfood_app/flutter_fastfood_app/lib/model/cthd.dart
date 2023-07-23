
import 'dart:convert';

List<CTHD> cthdFromMap(String str) => List<CTHD>.from(json.decode(str).map((x) => CTHD.fromMap(x)));

String cthdToMap(List<CTHD> data) => json.encode(List<dynamic>.from(data.map((x) => x.toMap())));

class CTHD {
    CTHD({
        required this.idHoaDon,
        required this.idMonAn,
        required this.soLuong,
        required this.giaBan,
        required this.thanhTien,
    });

    int idHoaDon;
    int idMonAn;
    int soLuong;
    int giaBan;
    int thanhTien;

    factory CTHD.fromMap(Map<String, dynamic> json) => CTHD(
        idHoaDon: json["ID_HoaDon"],
        idMonAn: json["ID_MonAn"],
        soLuong: json["SoLuong"],
        giaBan: json["GiaBan"],
        thanhTien: json["ThanhTien"],
    );

    Map<String, dynamic> toMap() => {
        "ID_HoaDon": idHoaDon,
        "ID_MonAn": idMonAn,
        "SoLuong": soLuong,
        "GiaBan": giaBan,
        "ThanhTien": thanhTien,
    };
}
