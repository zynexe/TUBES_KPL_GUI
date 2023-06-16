using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            internal string GetAttendanceStatus(bool isPresent)
            {
                return attendanceStatus[isPresent];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SystemNotifikasi systemNotifikasi = new SystemNotifikasi();

            // Simulasi data kehadiran mahasiswa
            systemNotifikasi.MarkAttendance("M001", true);
            systemNotifikasi.MarkAttendance("M002", false);
            systemNotifikasi.MarkAttendance("M003", true);
            systemNotifikasi.MarkAttendance("M004", false);

            // Mendapatkan ID mahasiswa dari TextBox1
            string studentId = textBox1.Text;

            // Memeriksa kehadiran mahasiswa dengan ID yang dimasukkan
            if (systemNotifikasi.GetAttendanceData().ContainsKey(studentId))
            {
                bool isPresent = systemNotifikasi.GetAttendanceData()[studentId];
                string attendanceStatusMsg = systemNotifikasi.GetAttendanceStatus(isPresent);

                // Menampilkan notifikasi pada label2
                label2.Text = $"Notifikasi Terkitrim : Mahasiswa {studentId} {attendanceStatusMsg} dari kelas hari ini.";
            }
            else
            {
                label2.Text = "ID mahasiswa tidak ditemukan.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
