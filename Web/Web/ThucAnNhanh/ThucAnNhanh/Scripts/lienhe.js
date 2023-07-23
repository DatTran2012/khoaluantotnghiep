function validateform() {
    var name = document.myform.name.value;
    var email = document.myform.email.value;
    var phonenumber = document.myform.phonenumber.value;
    var msg_subject = document.myform.msg_subject.value;
    var message = document.myform.message.value;


    if (name == "" || name == null) {
        document.getElementById('#loi').innerHTML("Vui lòng điền tên");
        return false;

    }
    if (email == "" || email == null) {
        document.getElementById('#loi').innerHTML("Vui lòng email");
        return false;
      
    }
}