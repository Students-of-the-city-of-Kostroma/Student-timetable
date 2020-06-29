﻿using System.Data;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// В этом классе храняться все экземпляры контроллеров.
    /// </summary>
    public class RefData {
        public DataSet DataSet = new DataSet();
        public CTeacher CTeacher = new CTeacher();
        public CAuditor CAuditor = new CAuditor();
        public CDiscipline CDiscipline = new CDiscipline();
        public CGroup CGroup = new CGroup();
        public CTitle CTitle = new CTitle();
        public CTrainingProfile CTrainingProfile = new CTrainingProfile();
        public CDirectionOfPreparation CDirectionOfPreparation = new CDirectionOfPreparation();
        public CEnclosures CEnclosures = new CEnclosures();
        public CUniversity CUniversity = new CUniversity();
        public CStudyWeek CStudyWeek = new CStudyWeek();
        public CInstitute CInstitute = new CInstitute();
        public CAcademicDegree CAcademicDegree = new CAcademicDegree();
        public CTypesOfOccupations CTypesOfOccupations = new CTypesOfOccupations();
        public CAcademicLoad CAcademicLoad = new CAcademicLoad();

        public  RefData() {
            DataSet.Tables.Add(CTrainingProfile);
            DataSet.Tables.Add(CDirectionOfPreparation);
            DataSet.Tables.Add(CAuditor);
            DataSet.Tables.Add(CEnclosures);
            DataSet.Tables.Add(CUniversity);
            DataSet.Tables.Add(CInstitute);
            DataSet.Tables.Add(CTeacher);
            DataSet.Tables.Add(CAcademicDegree);
            DataSet.Tables.Add(CTitle);
            DataSet.Tables.Add(CGroup);
            DataSet.Tables.Add(CStudyWeek);
            DataSet.Tables.Add(CDiscipline);
            DataSet.Tables.Add(CTypesOfOccupations);
            DataSet.Tables.Add(CAcademicLoad);

            DataSet.Relations.Add("Direction_TrainingProfile", CDirectionOfPreparation.Columns["CodeOfDP"], CTrainingProfile.Columns["Shiphr"]);
            DataSet.Relations.Add("Enclosures-Auditor", CEnclosures.Columns["Name"], CAuditor.Columns["Building"]);
            DataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["AcademicDegree"]);
            DataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["AcademicTitle"]);
            DataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
            DataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);
            DataSet.Relations.Add("Group-Training profile", CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
            DataSet.Relations.Add("University-Enclosures", CUniversity.Columns["FullName"], CEnclosures.Columns["University"]);
            DataSet.Relations.Add("AcademicLoad-Group", CGroup.Columns["Group"], CAcademicLoad.Columns["Group"]);
            DataSet.Relations.Add("AcademicLoad-Discipline", CAcademicLoad.Columns["Discipline"], CDiscipline.Columns["FullName"]);
            DataSet.Relations.Add("AcademicLoad-Teacher", CAcademicLoad.Columns["Professor"], CTeacher.Columns["FullName"]);
            DataSet.Relations.Add("AcademicLoad-TypesOfOccupations", CAcademicLoad.Columns["KindOfLesson"], CTypesOfOccupations.Columns["FullName"]);
            InitData();
        }
    
        private void InitData() {
            #region direction
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4);
            CDirectionOfPreparation.Insert(mDirectionOfPreparation);
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            CTrainingProfile.Insert(mTrainingProfile);
            MGroup mGroup = new MGroup("17-ИСбо-2а", 4, "ИС", 1, 20, 2, 5, "Суббота");
            CGroup.Insert(mGroup);

            MDirectionOfPreparation mDirectionOfPreparation1 = new MDirectionOfPreparation("09.03.03", "Прикладная информатика", 4);
            CDirectionOfPreparation.Insert(mDirectionOfPreparation1);
            MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Прикладная информатика", "ПИ", "09.03.03");
            CTrainingProfile.Insert(mTrainingProfile1);
            MGroup mGroup1 = new MGroup("17-ПИбо-4а", 5, "ПИ", 2, 19, 2, 5, "Воскресенье");
            CGroup.Insert(mGroup1);

            MDirectionOfPreparation mDirectionOfPreparation2 = new MDirectionOfPreparation("09.03.01", "Информатика и вычислительная техника", 4);
            CDirectionOfPreparation.Insert(mDirectionOfPreparation2);
            MTrainingProfile mTrainingProfile2 = new MTrainingProfile("Информатика и вычислительная техника", "ИВТ", "09.03.01");
            CTrainingProfile.Insert(mTrainingProfile2);
            MGroup mGroup2 = new MGroup("17-ВТбо-2б", 4, "ИВТ", 1, 20, 2, 5, "Суббота");
            CGroup.Insert(mGroup2);
            #endregion
            #region discipline
            MDiscipline mDiscipline = new MDiscipline("Web-программирование", "Web", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline);

            MDiscipline mDiscipline1 = new MDiscipline("Правоведение", "Право", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline1);

            MDiscipline mDiscipline2 = new MDiscipline("Операционные системы", "ОС", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline2);

            MDiscipline mDiscipline3 = new MDiscipline("Управление данными", "УД", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline3);

            MDiscipline mDiscipline4 = new MDiscipline("3D-моделирование", "3D", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline4);

            MDiscipline mDiscipline5 = new MDiscipline("Инструменты графического дизайна", "ИГД", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline5);

            MDiscipline mDiscipline6 = new MDiscipline("Физическая культура и спорт", "Физра", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline6);

            MDiscipline mDiscipline7 = new MDiscipline("Моделирование информационных систем", "МИС", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline7);

            #endregion
            #region academicdegree
            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            CAcademicDegree.Insert(mAcademicDegree);
            MTitle mTitle = new MTitle("Доцент", "Доц");
            CTitle.Insert(mTitle);
            MTeacher mTeacher = new MTeacher("Иван", "Иванов", "Иванович", "КН", "Доц", "ИАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher);

            MAcademicDegree mAcademicDegree1 = new MAcademicDegree("Доктор наук", "ДН");
            CAcademicDegree.Insert(mAcademicDegree1);
            MTitle mTitle1 = new MTitle("Профессор", "Проф");
            CTitle.Insert(mTitle1);
            MTeacher mTeacher1 = new MTeacher("Василий", "Михайлов", "Александрович", "ДН", "Проф", "ИФМЕН", "Вт, Чт", "ПН, ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher1);

            MAcademicDegree mAcademicDegree2 = new MAcademicDegree("Кандидат наук", "КН");
            CAcademicDegree.Insert(mAcademicDegree2);
            MTitle mTitle2 = new MTitle("Профессор", "Проф");
            CTitle.Insert(mTitle2);
            MTeacher mTeacher2 = new MTeacher("Валерий", "Аристархов", "Аристархович", "КН", "Проф", "ИПП", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher2);
            #endregion
            #region university
            MUniversity mUniversity = new MUniversity("4401006286", "КГУ", "Костромской Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Рудольфович", "Наумов", "info@kstu.edu.ru", "84942317960");
            CUniversity.Insert(mUniversity);

            MUniversity mUniversity1 = new MUniversity("7604011791", "ЯГУ", "Ярославский Государственный Университет", "150003, Ярославская область, г. Ярославль, ул. Советская, 14", "150003, Ярославская область, г. Ярославль,ул. Советская, 14", "Михаил", "Михайлович", "Котюков", "rectorat@uniyar.ac.ru", "84852797702");
            CUniversity.Insert(mUniversity1);

            MUniversity mUniversity2 = new MUniversity("7605009467", "ЯГТУ", "Ярославский Государственный Технический Университет", "150023, Ярославская область, г. Ярославль, ул. Московский пр., 88", "150023, Ярославская область, г. Ярославль, ул. Московский пр., 88", "Елена", "Олеговна", "Степанова", "rector@ystu.ru", "84852305661");
            CUniversity.Insert(mUniversity2);
            #endregion
            #region enclosures
            MEnclosures mEnclosures = new MEnclosures("Е", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 4", "84942536522", "Примечание");
            CEnclosures.Insert(mEnclosures);

            MEnclosures mEnclosures1 = new MEnclosures("А", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 6", "88005534535", "Примечание");
            CEnclosures.Insert(mEnclosures1);

            MEnclosures mEnclosures2 = new MEnclosures("Б", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 8", "84947004444", "Примечание");
            CEnclosures.Insert(mEnclosures2);
            #endregion
            #region institute
            MInstitute mInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Иванов Иван Иванович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute);

            MInstitute mInstitute1 = new MInstitute("Институт педагогики и психологии", "ИПП", "Аристархов Валерий Аристархович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute1);

            MInstitute mInstitute2 = new MInstitute("Институт физико математических и естественных наук", "ИФМЕН", "Михайлов Василий Александрович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute2);
            #endregion
            #region auditor
            InitEAuditors();

            MAuditor mAuditor1 = new MAuditor("214", "Педагогики", 80, "А");
            CAuditor.Insert(mAuditor1);

            MAuditor mAuditor2 = new MAuditor("123", "Философии", 77, "Б");
            CAuditor.Insert(mAuditor2);
            #endregion
            #region occupations
            MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations("Технология разработки программного обеспичения", "ТРПО");
            CTypesOfOccupations.Insert(mTypesOfOccupations);

            MTypesOfOccupations mTypesOfOccupations1 = new MTypesOfOccupations("Теория информационных процессов и систем", "ТИПИС");
            CTypesOfOccupations.Insert(mTypesOfOccupations1);

            MTypesOfOccupations mTypesOfOccupations2 = new MTypesOfOccupations("Инфокоммуникационные системы и сети", "ИСС");
            CTypesOfOccupations.Insert(mTypesOfOccupations2);
            #endregion
        }

        /// <summary>
        /// Создаёт список аудиторий для Е-корпуса
        /// </summary>
        private void InitEAuditors() {
            CAuditor.Insert(new MAuditor("100", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("101", "Физическая культура и спорт", 0, "Е"));
            CAuditor.Insert(new MAuditor("108", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("113", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("115", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("116", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("120", "Инженерная графика", 0, "Е"));
            CAuditor.Insert(new MAuditor("121", "Инженерная графика", 0, "Е"));
            CAuditor.Insert(new MAuditor("123", "Теоретическая механика", 0, "Е"));
            CAuditor.Insert(new MAuditor("128", "Инженерная и компьютерная графика", 0, "Е"));
            CAuditor.Insert(new MAuditor("203", "Информационная безопасность", 0, "Е"));
            CAuditor.Insert(new MAuditor("205", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("208", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("209", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("211", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("212", "Биология", 0, "Е"));
            CAuditor.Insert(new MAuditor("221", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("222", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("223", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("225", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("226", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("227", "Прикладная математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("228", "Прикладная математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("303а", "", 0, "Е"));
            CAuditor.Insert(new MAuditor("303б", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("304", "Физика", 0, "Е"));
            CAuditor.Insert(new MAuditor("305", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("306", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("308", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("309", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("312", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("313", "История", 0, "Е"));
            CAuditor.Insert(new MAuditor("314", "Иностранные языки", 0, "Е"));
            CAuditor.Insert(new MAuditor("317", "Прикладная математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("318", "", 0, "Е"));
            CAuditor.Insert(new MAuditor("319", "", 15, "Е"));
            CAuditor.Insert(new MAuditor("321", "Информационные системы", 0, "Е"));
            CAuditor.Insert(new MAuditor("323", "Информационные системы", 0, "Е"));
            CAuditor.Insert(new MAuditor("324", "Информационные системы", 0, "Е"));
            CAuditor.Insert(new MAuditor("325", "Информационные системы", 18, "Е"));
            CAuditor.Insert(new MAuditor("326", "Информационные системы", 100, "Е"));
            CAuditor.Insert(new MAuditor("327", "Вычислительная техника", 12, "Е"));
            CAuditor.Insert(new MAuditor("330", "Вычислительная техника", 12, "Е"));
            CAuditor.Insert(new MAuditor("401", "Информационная безопасность", 0, "Е"));
            CAuditor.Insert(new MAuditor("403", "Математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("405", "Математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("406", "Информационная безопасность", 0, "Е"));
            CAuditor.Insert(new MAuditor("407", "Информационные системы", 0, "Е"));
            CAuditor.Insert(new MAuditor("412", "Математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("413", "Математика", 0, "Е"));
            CAuditor.Insert(new MAuditor("430", "Военная кафедра", 0, "Е"));
            CAuditor.Insert(new MAuditor("501а", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("502", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("508", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("509", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("514", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("516", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("517", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("519", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("520", "Химия", 0, "Е"));
            CAuditor.Insert(new MAuditor("522", "", 0, "Е"));
            CAuditor.Insert(new MAuditor("523", "", 0, "Е"));
            CAuditor.Insert(new MAuditor("101", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("106", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("108", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("109", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("110", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("202", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("203", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("204", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("205", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("208", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("213", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("215", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("216", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("217", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("218", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("302", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("303", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("305", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("309", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("311", "Иностранные языки", 0, "Б"));
            CAuditor.Insert(new MAuditor("314", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("315", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("402", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("403", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("404", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("405", "Автоматика и микропроцессорная техника", 0, "Б"));
            CAuditor.Insert(new MAuditor("408", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("411", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("413", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("416", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("417", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("418", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("315", "", 0, "Б"));
            CAuditor.Insert(new MAuditor("103", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("104", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("106", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("107", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("108", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("110", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("301", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("303", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("305", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("309", "Технология машиностроения", 0, "А"));
            CAuditor.Insert(new MAuditor("311", "Технология машиностроения", 0, "А"));

        }
    }
}
