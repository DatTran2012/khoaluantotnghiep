import 'package:flutter/material.dart';


class HomeButton extends StatefulWidget {
  final String pathImg;
  final Function btnClick;
  final String btnName;
  const HomeButton({Key? key, required this.pathImg, required this.btnClick, required this.btnName}) : super(key: key);

  @override
  State<HomeButton> createState() => _HomeButtonState();
}

class _HomeButtonState extends State<HomeButton> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        ElevatedButton(
          child: Image.network(
            widget.pathImg,
            width: 84,
            height: 84,
          ),
          style: ElevatedButton.styleFrom(
              padding: const EdgeInsets.all(8.0),
              minimumSize: const Size(150, 150),
              primary: Colors.white),
          onPressed: () => widget.btnClick(),
          
        ),
        Padding(
          padding: const EdgeInsets.only(top: 10),
          child: Text(
            widget.btnName,
            style: const TextStyle(
              fontSize: 16,
            ),
          ),
        ),
      ],
    );
  }
}
