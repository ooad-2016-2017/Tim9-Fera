using System;
using SQLite.Net;
using System.IO;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;
using Windows.Storage.Streams;
using Windows.Security.Cryptography;

namespace SmartSchoolSystem.DataAccess
{
    public class SmartSchoolDataSource
    {
        String path;
        public SmartSchoolDataSource()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MainDatabase.sqlite");
            Debug.WriteLine(path);
        }
        public String getDatabaPath()
        {
            return path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MainDatabase.sqlite");
        }
       
        public void konektuj()
        {
            using(var connection= new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                connection.Execute("CREATE TABLE IF NOT EXISTS Korisnici (ID Integer Primary Key Autoincrement NOT NULL,"
                                                                + "Ime VARCHAR(50), Prezime VARCHAR(50),"
                                                                + "MjestoRodenja VARCHAR(50),"
                                                                + "Jmbg VARCHAR(20), Drzavljanstvo VARCHAR(10),"
                                                                + "Razrednik VARCHAR(5),"
                                                                + "Spol VARCHAR(10), Email VARCHAR(30),"
                                                                + "KontaktTel VARCHAR(20),"
                                                                + "Username VARCHAR(100) NOT NULL, PassHash VARCHAR(50) NOT NULL,"
                                                                + "VrstaKorisnika VARCHAR(15) NOT NULL)");
                connection.Execute("CREATE TABLE IF NOT EXISTS Ucenici (ID Integer Primary Key Autoincrement NOT NULL,"
                                                                  + "Ime VARCHAR(50), Prezime VARCHAR(50),"
                                                                  + "MjestoRodenja VARCHAR(50),"
                                                                  + "Jmbg VARCHAR(20), Spol VARCHAR(10),"
                                                                  + "ImeRod VARCHAR(50), PrezimeRod VARCHAR(50),"
                                                                  + "ZanimanjeRod VARCHAR(60), Razred INTEGER)");
                connection.Execute("CREATE TABLE IF NOT EXISTS Predmeti (ID Integer Primary Key Autoincrement NOT NULL,"
                                                                  + "Naziv VARCHAR(30))");
                //connection.Execute("INSERT INTO Korisnici(Username,PassHash,VrstaKorisnika) VALUES('admin','admin','Administrator')");
            }
            //conn.CreateTable<Model.Korisnik>();
            
        }

        public Model.Korisnik findUser(String username,String pass)
        {
            using(var connection= new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                List<Model.Korisnik> users = connection.Query<Model.Korisnik>("SELECT * FROM Korisnici");
                foreach (var item in users)
                {
                    if (item.Username == username && item.PassHash == pass)
                    {
                        return item;
                    }
                }
            }
            
            //var query = conn.Table<Model.Korisnik>();
            return null;
        }

        public List<Model.Ucenik> getAllStudents()
        {
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                return connection.Query<Model.Ucenik>("SELECT * FROM Ucenici");
            }
        }

        public List<Model.Predmet> getAllSubjects()
        {
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                return connection.Query<Model.Predmet>("SELECT * FROM Predmeti");
            }
        }

        public Boolean DoesItExists(String imePredmeta)
        {
            List<Model.Predmet> subjects = new List<Model.Predmet>();
            subjects = getAllSubjects();
            foreach(var item in subjects)
            {
                if (item.Naziv == imePredmeta)
                    return true;
            }
            return false;
        }

        public int getNumberOfStudents()
        {
            using (var connection = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path))
            {
                return connection.Query<Model.Ucenik>("SELECT * FROM Ucenici").Count;
            }
        }

        public string GenerateRandomData()
        {
            // Define the length, in bytes, of the buffer.
            uint length = 8;

            // Generate random data and copy it to a buffer.
            IBuffer buffer = CryptographicBuffer.GenerateRandom(length);

            // Encode the buffer to a hexadecimal string (for display).
            string randomHex = CryptographicBuffer.EncodeToHexString(buffer);

            return randomHex;

        }
    }

}
