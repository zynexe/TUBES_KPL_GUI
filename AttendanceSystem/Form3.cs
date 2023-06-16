using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public class SystemNotifikasi
        {
            private Dictionary<string, bool> attendanceData;
            private Dictionary<bool, string> attendanceStatus;

            public SystemNotifikasi()
            {
                attendanceData = new Dictionary<string, bool>();
                attendanceStatus = new Dictionary<bool, string> {
                { true, "Hadir" }, // Status kehadiran true berarti "Hadir"
                { false, "Absen" } // Status kehadiran false berarti "Absen"
            };
            }

            public Dictionary<string, bool> GetAttendanceData()
            {
                return attendanceData;
            }

            public void MarkAttendance(string studentId, bool isPresent)
            {
                attendanceData[studentId] = isPresent;
            }

            public void AlertAbsentStudents()
            {
                foreach (KeyValuePair<string, bool> studentAttendance in attendanceData)
                {
                    string studentId = studentAttendance.Key;
                    bool isPresent = studentAttendance.Value;
                    string attendanceStatusMsg = attendanceStatus[isPresent];
                    // Menampilkan notifikasi absen untuk setiap mahasiswa
                    Console.WriteLine("Notifikasi Absen {0}: Anda {1} dari kelas hari ini.", studentId, attendanceStatusMsg);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
