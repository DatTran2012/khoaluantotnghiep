import 'package:flutter/material.dart';
import 'package:flutter_fastfood_app/model/user.dart';

class DialogProfile extends StatelessWidget {
  final User user;
  const DialogProfile({Key? key, required this.user}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Dialog(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
      child: SizedBox(
        height: 470,
        child: Column(
          children: [
            SizedBox(height: 4,),
            SizedBox(
                height: 190,
                child: ClipRRect(
                    borderRadius: BorderRadius.circular(15),
                    child: Image.network(
                      user.anh,
                      fit: BoxFit.cover,
                    ))),
            Padding(
              padding: const EdgeInsets.only(top: 12.0),
              child: Text(
                user.tenNv,
                style: const TextStyle(
                    fontSize: 16.0, fontWeight: FontWeight.bold),
              ),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(16, 12, 16, 0),
              child: Column(
                children: <Widget>[
                  Row(
                    children: [
                      const Icon(Icons.cake_rounded),
                      const SizedBox(
                        width: 20,
                      ),
                      Text(user.ngaySinh.toString())
                    ],
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 12.0),
                    child: Row(
                      children: [
                        const Icon(Icons.assignment_ind_rounded),
                        const SizedBox(
                          width: 20,
                        ),
                        Text(user.cmt)
                      ],
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 12.0),
                    child: Row(
                      children: [
                        const Icon(Icons.phone),
                        const SizedBox(
                          width: 20,
                        ),
                        Text(user.sdt)
                      ],
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 12.0),
                    child: Row(
                      children: [
                        const Icon(Icons.date_range),
                        const SizedBox(
                          width: 20,
                        ),
                        Text(user.ngayVl.toIso8601String())
                      ],
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 12.0),
                    child: Row(
                      children: [
                        const Icon(Icons.maps_home_work_sharp),
                        const SizedBox(
                          width: 20,
                        ),
                        Expanded(
                            child: Text(
                          user.diaChi,
                          maxLines: 4,
                        ))
                      ],
                    ),
                  ),
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
