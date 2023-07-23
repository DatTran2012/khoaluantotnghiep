
import 'dart:convert';

List<HoaDon> hoaDonFromMap(String str) => List<HoaDon>.from(json.decode(str).map((x) => HoaDon.fromMap(x)));

HoaDon hoaDonFromJson(String str) => HoaDon.fromMap(json.decode(str));

String hoaDonToMap(List<HoaDon> data) => json.encode(List<dynamic>.from(data.map((x) => x.toMap())));

class HoaDon {
    HoaDon({
        required this.id,
        required this.ngayLap,
        required this.tongTien,
        required this.idNhanVien,
        required this.idKhachHang,
        required this.idBanAn,
        required this.tinhTrang,
    });

    int id;
    DateTime ngayLap;
    int tongTien;
    String idNhanVien;
    int idKhachHang;
    int idBanAn;
    String tinhTrang;

    factory HoaDon.fromMap(Map<String, dynamic> json) => HoaDon(
        id: json["ID"],
        ngayLap: DateTime.parse(json["NgayLap"]),
        tongTien: json["TongTien"],
        idNhanVien: json["ID_NhanVien"],
        idKhachHang: json["ID_KhachHang"],
        idBanAn: json["ID_BanAn"],
        tinhTrang: json["TinhTrang"],
    );

    Map<String, dynamic> toMap() => {
        "ID": id,
        "NgayLap": ngayLap.toIso8601String(),
        "TongTien": tongTien,
        "ID_NhanVien": idNhanVien,
        "ID_KhachHang": idKhachHang,
        "ID_BanAn": idBanAn,
        "TinhTrang": tinhTrang,
    };
}
