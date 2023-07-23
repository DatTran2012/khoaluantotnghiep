import 'dart:convert';

import 'package:flutter/foundation.dart';
import 'package:flutter_fastfood_app/model/cthd.dart';
import 'package:flutter_fastfood_app/model/food.dart';
import 'package:flutter_fastfood_app/model/hoadon.dart';
import 'package:flutter_fastfood_app/model/phancong.dart';
import 'package:flutter_fastfood_app/model/table.dart';
import 'package:flutter_fastfood_app/model/user.dart';
import 'package:http/http.dart' as http;
import 'package:flutter_fastfood_app/res/strings.dart' as strings;

class APIService {
  //User=================================================================
  Future<User> fetchUsers(String id) async {
    final response = await http.get(Uri.parse(
        'http://${strings.ip}//fastfooddataserver/api/NhanVien/GetNV/$id'));
    if (response.statusCode == 200) {
      print('Status code: ${response.statusCode}');
      return userFromJson(response.body);
    } else if (response.statusCode == 404) {
      throw Exception(response.statusCode);
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int?> updatePass(User user, String mkmoi) async {
    try {
      final response = await http.put(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/NhanVien/UpdateNV'),
        headers: {"Content-type": "application/json"},
        body: json.encode({
          "ID": user.id,
          "TenNV": user.tenNv,
          "NgaySinh": user.ngaySinh.toIso8601String(),
          "GioiTinh": user.gioiTinh,
          "DiaChi": user.diaChi,
          "SDT": user.sdt,
          "CMT": user.cmt,
          "Anh": user.anh,
          "NgayVL": user.ngayVl.toIso8601String(),
          "MatKhau": mkmoi,
        }),
      );
      return response.statusCode;
    } catch (e) {
      print(e);
    }
  }

  static List<PhanCong> parsePhanCong(String responeBody) {
    var list = json.decode(responeBody) as List<dynamic>;
    List<PhanCong> pcs =
        list.map((model) => PhanCong.fromMap(model)).toList();
    return pcs;
  }

  static Future<List<PhanCong>> fetchPhanCongs(String id) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Phancong/GetPhanCongByMaNVNgay/$id'));
    if (respone.statusCode == 200) {
      return compute(parsePhanCong, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<List<PhanCong>> countDaDiemDanh(String id) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Phancong/GetDaDiemDanh/$id'));
    if (respone.statusCode == 200) {
      return compute(parsePhanCong, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int> countVang(String id) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Phancong/GetVang/$id'));
    if (respone.statusCode == 200) {
      return respone.body.length;
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int> countTre(String id) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Phancong/GetVang/$id'));
    if (respone.statusCode == 200) {
      return respone.body.length;
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static List<PhanCong> parseSchedule(String responeBody) {
    var list = json.decode(responeBody) as List<dynamic>;
    List<PhanCong> pcs =
        list.map((model) => PhanCong.fromMap(model)).toList();
    return pcs;
  }

  static Future<List<PhanCong>> fetchSchedules(String id) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/PhanCong/GetPhanCongByMaNV/$id'));
    if (respone.statusCode == 200) {
      return compute(parsePhanCong, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int?> updateDiemDanhStatus(PhanCong phanCong) async {
    try {
      final response = await http.put(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/PhanCong/UpdateDiemDanh'),
        headers: {"Content-type": "application/json"},
        body: json.encode({
            "IDNV": phanCong.idnv,
            "CaLam": phanCong.caLam,
            "NgayLam": phanCong.ngayLam.toIso8601String(),
            "DiemDanh": phanCong.diemDanh,
        }),
      );
      print(phanCong.ngayLam.toIso8601String());
      return response.statusCode;
    } catch (e) {
      print(e);
    }
  }

  //============================TABLE==========================================
  static List<TableModel> parseTable(String responeBody) {
    var list = json.decode(responeBody) as List<dynamic>;
    List<TableModel> tables =
        list.map((model) => TableModel.fromMap(model)).toList();
    return tables;
  }

  static Future<List<TableModel>> fetchTables({int page = 1}) async {
    final respone = await http.get(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Ban/GetListBan'));
    if (respone.statusCode == 200) {
      return compute(parseTable, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<List<TableModel>> fetchCountTables() async {
    final respone = await http.get(Uri.parse(
        'http://${strings.ip}/fastfooddataserver/api/Ban/GetListBanCoKhach'));
    if (respone.statusCode == 200) {
      return compute(parseTable, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<List<TableModel>> fetchCountTablesNull() async {
    final respone = await http.get(Uri.parse(
        'http://${strings.ip}/fastfooddataserver/api/Ban/GetListBanTrong'));
    if (respone.statusCode == 200) {
      return compute(parseTable, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int?> updateTableStatus(TableModel tableModel, int status) async {
    try {
      final response = await http.put(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/Ban/UpdateTTBan'),
        headers: {"Content-type": "application/json"},
        body: json.encode({
          "ID": tableModel.id,
          "ViTri": tableModel.viTri,
          "TinhTrang": status,
        }),
      );
      print('Cập nhật thành công');
      return response.statusCode;
    } catch (e) {
      print(e);
    }
  }

  //================================FOOD====================================
  static List<Food> parseFood(String responeBody) {
    var list = json.decode(responeBody) as List<dynamic>;
    List<Food> foods = list.map((model) => Food.fromMap(model)).toList();
    return foods;
  }

  static Future<List<Food>> fetchFoods({int page = 1}) async {
    final respone = await http.get(Uri.parse(
        'http://${strings.ip}/fastfooddataserver/api/MonAn/GetListMonAn'));
    if (respone.statusCode == 200) {
      return compute(parseFood, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  //===================================HÓA ĐƠN==========================================
  static createHoaDon(int mahd, DateTime ngaylap, String idnv, int idban) async {
    try {
      final response = await http.post(
          Uri.parse('http://${strings.ip}/fastfooddataserver/api/HoaDon/CreateHoaDon'),
          headers: {"Content-type": "application/json"},
          body: json.encode({
            "ID": mahd,
            "NgayLap": ngaylap.toIso8601String(),
            "TongTien": 0,
            "ID_NhanVien": idnv,
            "ID_KhachHang": 0,
            "ID_BanAn": idban,
            "TinhTrang": "Chưa thanh toán"
          }
        )
      );
      print(response.body);
    } catch (e) {
      print(e);
    }
  }
  
  static List<HoaDon> parseHD(String responeBody) {
    var list = json.decode(responeBody) as List<dynamic>;
    List<HoaDon> hds = list.map((model) => HoaDon.fromMap(model)).toList();
    return hds;
  }

  static Future<List<HoaDon>> fetchHDs({int page = 1}) async {
    final respone = await http.get(
      Uri.parse('http://${strings.ip}/fastfooddataserver/api/HoaDon/GetListHoaDon')
    );
    if (respone.statusCode == 200) {
      return compute(parseHD, respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception('Not Found');
    } else {
      throw Exception('Can\'t get data');
    }
  }

  Future<HoaDon> fetchHDByIDBan(int idban) async {
    final respone = await http.get(
      Uri.parse('http://${strings.ip}/fastfooddataserver/api/HoaDon/GetListByIDBan/$idban')
    );
    if (respone.statusCode == 200) {
      print('Status code: ${respone.statusCode}');
      return hoaDonFromJson(respone.body);
    } else if (respone.statusCode == 404) {
      throw Exception(respone.statusCode);
    } else {
      throw Exception('Can\'t get data');
    }
  }

  static Future<int?> updateHoaDon(HoaDon hd) async {
    try {
      final response = await http.put(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/HoaDon/UpdateHD'),
        headers: {"Content-type": "application/json"},
        body: json.encode({
            "ID": hd.id,
            "NgayLap": hd.ngayLap.toIso8601String(),
            "TongTien": hd.tongTien,
            "ID_NhanVien": hd.idNhanVien,
            "ID_KhachHang": hd.idKhachHang,
            "ID_BanAn": hd.idBanAn,
            "TinhTrang": hd.tinhTrang
          }
        )
      );
      print('Yêu cầu thanh toán hóa đơn thành công');
      return response.statusCode;
    } catch (e) {
      print(e);
    }
  }

  //=========================CHI TIẾT HÓA ĐƠN=====================================
  static insertListCTHD(List<CTHD> cthd) async {
    try {
      final response = await http.post(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/CTHD/InsertListCTHD'), 
        headers: {"Content-type": "application/json"},
        body: jsonEncode(cthd.map((i) => i.toMap()).toList())
      );
      print(response.body);
    } catch (e) {
      print(e);
    }
  }

  //=========================NGUYÊN LIỆU=====================================
  static Future<int?> updateSLNguyenLieu(List<CTHD> cthds) async {
    try {
      final response = await http.put(
        Uri.parse('http://${strings.ip}/fastfooddataserver/api/NguyenLieu/UpdateSLTNGuyenLieu'),
        headers: {"Content-type": "application/json"},
        body: jsonEncode(cthds.map((i) => i.toMap()).toList())
      );
      print(response.statusCode);
      print(response.body.length.toString());
      return response.statusCode;
    } catch (e) {
      print(e);
    }
  }
}
