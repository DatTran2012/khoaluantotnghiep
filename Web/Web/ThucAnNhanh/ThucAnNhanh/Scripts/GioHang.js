$('#add-to-cart').on('click', function (e) {
    var idMA = $('#idMA').val();
    var sl = $('#soluong').val();
    $.ajax({
        type: "GET",
        url: '/GioHang/ThemGioHang',
        data: {
            id: idMA,
            sl: sl
        },
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            if (data.kq) {
                alert("Thêm vào giỏ hàng thành công");
                window.location.reload();
            }
        }
    });
});

//$('#thanhtoan').on('click', function (e) {
//    var idMA = $('#idMA').val();
//    var sl = $('#soluong').val();
//    $.ajax({
//        type: "GET",
//        url: '/GioHang/ThemGioHangTT',
//        data: {
//            id: idMA,
//            sl: sl
//        },
//        dataType: "html",
//        contentType: "application/json;charset=utf-8",
//        success: function (data) {
//            if (data.kq) {
//                alert("Thanh toán");
//            }
//        }
//    });
//});

function ThemGioHang(e) {
    var id = $(e).attr('id');
    $.ajax({
        type: "GET",
        url: '/GioHang/ThemGioHangMA',
        data: {
            id: id,
        },
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            if (data.kq) {
                alert("Thêm vào giỏ hàng thành công");
                window.location.reload();
            }
        }
    });
}
function xoagiohang(e) {
    var id = $(e).attr('id');
    $.ajax({
        type: "GET",
        url: '/GioHang/XoaGioHang',
        data: {
            id: id,
        },
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            if (data.kq) {
                alert("Xóa giỏ hàng thành công");
                 window.location.reload();
            }
        }
    });
}
