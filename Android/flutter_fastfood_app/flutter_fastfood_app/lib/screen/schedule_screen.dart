import 'package:flutter/material.dart';
import 'package:flutter_fastfood_app/api/api_service.dart';
import 'package:flutter_fastfood_app/model/phancong.dart';
import 'package:syncfusion_flutter_calendar/calendar.dart';
import 'package:flutter_fastfood_app/res/colors.dart' as color;


class ScheduleScreen extends StatefulWidget {
  final String id;
  const ScheduleScreen({Key? key, required this.id}) : super(key: key);

  @override
  _ScheduleScreenState createState() => _ScheduleScreenState();
}

class _ScheduleScreenState extends State<ScheduleScreen> {

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: color.orangeMain,
        foregroundColor: Colors.white,
        centerTitle: true,
        title: const Text('LỊCH LÀM VIỆC'),
      ),
      body: FutureBuilder(
        future: APIService.fetchSchedules(widget.id),
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          if (snapshot.hasData) {
            return SfCalendar(
              view: CalendarView.month,
              monthViewSettings: const MonthViewSettings(showAgenda: true),
              dataSource: ScheduleDataSource(snapshot.data),
              initialDisplayDate: snapshot.data[0].ngayLam,
            );
          } else if (snapshot.hasError) {
            return const Center(child: Text('Không có lịch làm'),);
          } else {
            return const Center(child: CircularProgressIndicator(),);
          }
        },
      ),
    );
  }
}

class ScheduleDataSource extends CalendarDataSource {
  ScheduleDataSource(List<PhanCong> source) {
    appointments = source;
  }

  @override
  DateTime getStartTime(int index) {
    return appointments![index].ngayLam;
  }

  @override
  String getSubject(int index) {
    return 'Ca ${appointments![index].caLam}';
  }

  @override
  DateTime getEndTime(int index) {
    return appointments![index].ngayLam;
  }
}
