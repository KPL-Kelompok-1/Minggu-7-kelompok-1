﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection;
using System.Text.Json;
using System.IO;
using TPMOD07;
using System.Text.Json.Serialization;


class Program
{
    static void Main(string[] args)
    {


        // read json file

        string json = File.ReadAllText("C:\\Users\\USER\\Documents\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_1_1302223055.json");

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };
        DataMahasiswa_1302223055 data = JsonSerializer.Deserialize<DataMahasiswa_1302223055>(json, options);
        data.details();
        //File.WriteAllText("C:\\Users\\USER\\Documents\\Kuliah\\Semester 4\\KPL\\Praktikum\\TPMOD07\\TPMOD07\\TPMOD07\\tp7_1_1302220065.json",);

        string Default_Course = File.ReadAllText("C:\\Users\\USER\\Documents\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302223055.json");
        KuliahMahasiswa_1302223055 data2 = JsonSerializer.Deserialize<KuliahMahasiswa_1302223055>(Default_Course, options);
        data2.PrintCourses();

        string MyCourse = File.ReadAllText("C:\\Users\\USER\\Documents\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\matkul.json");
        KuliahMahasiswa_1302223055 data3 = JsonSerializer.Deserialize<KuliahMahasiswa_1302223055>(MyCourse, options);
        data3.PrintCourses();
        data2.changeToMyCourse(data3);

        string new_Course = JsonSerializer.Serialize(data3, options);
        File.WriteAllText("C:\\Users\\USER\\Documents\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302223055.json", new_Course);




    }
}