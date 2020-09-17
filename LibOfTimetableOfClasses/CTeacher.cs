﻿using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные о преподавателях в Университете
    /// </summary>
    public class CTeacher : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля FullName.
        /// </summary>
        public CTeacher() : base("Учитель")
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FullName",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "AcademicDegree"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "AcademicTitle"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Departament"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "MetodicalDays"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Windows"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Weekends"
            };
            this.Columns.Add(column);
        }

        /// <summary>
        /// Метод вставки переданной модели MTeacher в таблицу CTeacher
        /// в случае уникальности свойства FullName модели для таблицы CTeacher
        /// </summary>
        /// <param name="model">Вставляемая в CTeacher модель</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MTeacher mTeacher = (MTeacher)model;
            try
            {
                string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
                DataRow newRow = this.NewRow();
                newRow["FullName"] = fullName;
                newRow["AcademicDegree"] = mTeacher.AcademicDegree;
                newRow["AcademicTitle"] = mTeacher.AcademicTitle;
                newRow["Departament"] = mTeacher.Departament;
                newRow["MetodicalDays"] = mTeacher.MetodicalDays;
                newRow["Windows"] = mTeacher.Windows;
                newRow["Weekends"] = mTeacher.Weekends;
                this.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        /// <summary>
        /// Обновление свойств строки в таблице CTeacher из переданной модели MTeacher
        /// Поиск изменяемой строки CTeacher осуществляется по полю "FullName"
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Успешность выполнения операции</returns>
        public bool Update(Model model)
        {
            MTeacher mTeacher = (MTeacher)model;
            string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["FullName"] == fullName)
                    try
                    {
                        DataRow newRow = this.Rows[i];
                        newRow["AcademicDegree"] = mTeacher.AcademicDegree;
                        newRow["AcademicTitle"] = mTeacher.AcademicTitle;
                        newRow["Departament"] = mTeacher.Departament;
                        newRow["MetodicalDays"] = mTeacher.MetodicalDays;
                        newRow["Windows"] = mTeacher.Windows;
                        newRow["Weekends"] = mTeacher.Weekends;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Source);
                        return false;
                    }
            }
            return false;
        }

        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CTeacher.
        /// В таблице CTeacher ищется строка с полями "FullName" и "Departament" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка. 
        /// </summary>
        /// <param name="model">Модель, выбранной строки в таблице</param>
        /// <returns>Результат удаления переданной строки из CTeacher</returns>
        public bool Delete(Model model)
        {
            MTeacher mTeacher = (MTeacher)model;
            string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["FullName"] == fullName && (string)this.Rows[i]["Departament"] == mTeacher.Departament)
                {
                    this.Rows[i].Delete();
                    //Recount(i);
                    return true;
                }
            }
            return false;
        }
    }
}