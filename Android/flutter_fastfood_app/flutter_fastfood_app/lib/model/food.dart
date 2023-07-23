import 'dart:convert';

Food foodFromMap(String str) => Food.fromMap(json.decode(str));

String foodToMap(Food data) => json.encode(data.toMap());

class Food {
    Food({
        required this.id,
        required this.tenMa,
        required this.anh,
        required this.moTa,
        required this.tinhTrang,
        required this.idLoaiMa,
        required this.giaBan,
        required this.giaKhuyenMai,
    });

    int id;
    String tenMa;
    String anh;
    String moTa;
    int tinhTrang;
    int idLoaiMa;
    int giaBan;
    int giaKhuyenMai;

    factory Food.fromMap(Map<String, dynamic> json) => Food(
        id: json["ID"],
        tenMa: json["TenMA"],
        anh: json["Anh"],
        moTa: json["MoTa"],
        tinhTrang: json["TinhTrang"],
        idLoaiMa: json["ID_LoaiMA"],
        giaBan: json["GiaBan"],
        giaKhuyenMai: json["GiaKhuyenMai"],
    );

    Map<String, dynamic> toMap() => {
        "ID": id,
        "TenMA": tenMa,
        "Anh": anh,
        "MoTa": moTa,
        "TinhTrang": tinhTrang,
        "ID_LoaiMA": idLoaiMa,
        "GiaBan": giaBan,
        "GiaKhuyenMai": giaKhuyenMai,
    };
}
