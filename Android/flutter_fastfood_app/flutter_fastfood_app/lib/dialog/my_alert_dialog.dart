import 'package:flutter/material.dart';

class MyAlertDialog extends StatefulWidget {
  final String title;
  final String content;
  final String btnLeft;
  final String btnRight;
  final Function btnLeftClick;
  final Function btnRightClick;
  const MyAlertDialog({Key? key, required this.title, required this.content, required this.btnLeft, required this.btnRight, required this.btnLeftClick, required this.btnRightClick}) : super(key: key);

  @override
  _MyAlertDialogState createState() => _MyAlertDialogState();
}

class _MyAlertDialogState extends State<MyAlertDialog> {
  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: Text(widget.title),
      content: Text(widget.content),
      actions: <Widget>[
        TextButton(
          onPressed: () => widget.btnLeftClick(),
          child: Text(widget.btnLeft),
        ),
        TextButton(
          onPressed: () => widget.btnRightClick(),
          child: Text(widget.btnRight, style: const TextStyle(color: Colors.green),),
        ),
      ],
    );
  }
}
