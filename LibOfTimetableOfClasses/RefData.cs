using System;
using System.Data;
using System.Linq;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// В этом классе храняться все экземпляры контроллеров.
    /// </summary>
    public class RefData {
        public DataSet DataSet = new DataSet();
        /// <summary>
        /// Преподаватели
        /// </summary>
        public CTeacher CTeacher = new CTeacher();
        /// <summary>
        /// Аудитории
        /// </summary>
        public CAuditor CAuditor = new CAuditor();
        /// <summary>
        /// Дисциплины (Предметы)
        /// </summary>
        public CDiscipline CDiscipline = new CDiscipline();
        /// <summary>
        /// Группы
        /// </summary>
        public CGroup CGroup = new CGroup();
        /// <summary>
        /// Ученое звание
        /// </summary>
        public CTitle CTitle = new CTitle();
        /// <summary>
        /// Профили подготовки Университета
        /// </summary>
        public CTrainingProfile CTrainingProfile = new CTrainingProfile();
        /// <summary>
        /// Направления подготовки
        /// </summary>
        public CDirectionOfPreparation CDirectionOfPreparation = new CDirectionOfPreparation();
        /// <summary>
        /// Корпуса Университета
        /// </summary>
        public CEnclosures CEnclosures = new CEnclosures();
        /// <summary>
        /// Университеты
        /// </summary>
        public CUniversity CUniversity = new CUniversity();
        /// <summary>
        /// Учебная неделя (?)
        /// </summary>
        public CStudyWeek CStudyWeek = new CStudyWeek();
        /// <summary>
        /// Институты
        /// </summary>
        public CInstitute CInstitute = new CInstitute();
        /// <summary>
        /// Учёные степени
        /// </summary>
        public CAcademicDegree CAcademicDegree = new CAcademicDegree();
        /// <summary>
        /// Вид занятия
        /// </summary>
        public CTypesOfOccupations CTypesOfOccupations = new CTypesOfOccupations();
        /// <summary>
        /// Академическая нагрузка
        /// </summary>
        public CAcademicLoad CAcademicLoad = new CAcademicLoad();
        /// <summary>
        /// Расписание занятий
        /// </summary>
        public CCourseSchedule CCourseSchedule = new CCourseSchedule();

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
            DataSet.Tables.Add(CCourseSchedule);

            DataSet.Relations.Add("Direction_TrainingProfile", CDirectionOfPreparation.Columns["CodeOfDP"], CTrainingProfile.Columns["Shiphr"]);
            DataSet.Relations.Add("Institute-DirectionOfPreparation", CInstitute.Columns["ShortName"], CDirectionOfPreparation.Columns["InstituteShortName"]);
            DataSet.Relations.Add("Enclosures-Auditor", CEnclosures.Columns["Name"], CAuditor.Columns["Building"]);

            DataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["AcademicTitle"]);
            DataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["AcademicDegree"]);
            DataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
            DataSet.Relations.Add("Teacher-AcademicLoad", CTeacher.Columns["FullName"], CAcademicLoad.Columns["Professor"]);

            DataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);
            DataSet.Relations.Add("University-Enclosures", CUniversity.Columns["FullName"], CEnclosures.Columns["University"]);

            DataSet.Relations.Add("Group-Training profile", CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
            DataSet.Relations.Add("Group-AcademicLoad", CGroup.Columns["Group"],  CAcademicLoad.Columns["Group"]);

            DataSet.Relations.Add("Discipline-AcademicLoad", CDiscipline.Columns["FullName"], CAcademicLoad.Columns["Discipline"]);
            DataSet.Relations.Add("TypesOfOccupations-AcademicLoad", CTypesOfOccupations.Columns["FullName"], CAcademicLoad.Columns["KindOfLesson"]);

            DataSet.Relations.Add("AcademicLoad-CourseSchedule", CAcademicLoad.Columns["ID"], CCourseSchedule.Columns["AcademicId"]);
        }

        /// <summary>
        /// Загрузка тестовых данных, в последовательности, соответствующей DataSet.Relations
        /// Последовательность не менять - сломается загрузка.
        /// </summary>
        public void InitData()
        {
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
            
            #region auditor
            InitEAuditors();

            MAuditor mAuditor1 = new MAuditor("214", "Педагогики", 80, "А");
            CAuditor.Insert(mAuditor1);

            MAuditor mAuditor2 = new MAuditor("123", "Философии", 77, "Б");
            CAuditor.Insert(mAuditor2);
            #endregion

            #region title
            MTitle mTitle = new MTitle("Доцент", "Доц");
            CTitle.Insert(mTitle);
            MTitle mTitle1 = new MTitle("Профессор", "Проф");
            CTitle.Insert(mTitle1);
            MTitle mTitle2 = new MTitle("Нет звания", " ");
            CTitle.Insert(mTitle2);
            #endregion

            #region academicdegree
            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            CAcademicDegree.Insert(mAcademicDegree);
            MAcademicDegree mAcademicDegree1 = new MAcademicDegree("Доктор наук", "ДН");
            CAcademicDegree.Insert(mAcademicDegree1);
            MAcademicDegree mAcademicDegree2 = new MAcademicDegree("Нет ученой степени", " ");
            CAcademicDegree.Insert(mAcademicDegree2);
            #endregion

            #region teacher
            MTeacher mTeacher = new MTeacher("Иван", "Иванов", "Иванович", "КН", "Доц", "ИАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher);
            MTeacher mTeacher1 = new MTeacher("Василий", "Михайлов", "Александрович", "ДН", "Проф", "ИФМЕН", "Вт, Чт", "ПН, ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher1);
            MTeacher mTeacher2 = new MTeacher("Валерий", "Аристархов", "Аристархович", "КН", "Проф", "ИПП", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher2);
            MTeacher mTeacher3 = new MTeacher("Любовь", "Бекенева", "Александровна", "КН", "Проф", "ИДПО", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher3);
            MTeacher mTeacher4 = new MTeacher("Лариса", "Селиванова", "Ивановна", "КН", "Проф", "ИПР", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher4);
            MTeacher mTeacher5 = new MTeacher("Маргарита", "Беркович", "Израйлевна", "КН", "Проф", "ИУЭФ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher5);
            MTeacher mTeacher6 = new MTeacher("Ольга", "Панкратова", "Борисовна", "КН", "Проф", "ИГНИСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher6);
            MTeacher mTeacher7 = new MTeacher("Сергей", "Шорохов", "Александрович", "КН", "Проф", "ИДТ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher7);
            MTeacher mTeacher8 = new MTeacher("Геннадий", "Бриль", "Геннадьевич", "КН", "Проф", "ЮИН", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher8);
            MTeacher mTeacher9 = new MTeacher("Надежда", "Домахина", "Михайловна", "КН", "Проф", "ИКИ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher9);
            MTeacher mTeacher10 = new MTeacher("Нина", "Прядкина", "Олеговна", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher10);
            MTeacher mTeacher11 = new MTeacher("Александр", "Гутман", "Сергеевич", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher11);
            MTeacher mTeacher12 = new MTeacher("Игорь", "Панин", "Григорьевич", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher12);
            MTeacher mTeacher13 = new MTeacher("Александра", "Чувиляева", "Сергеевна", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher13);
            MTeacher mTeacher14 = new MTeacher("Александр", "Орлов", "Валерьевич", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher14);
            MTeacher mTeacher15 = new MTeacher("Елена", "Демчинова", "Александровна", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher15);
            MTeacher mTeacher16 = new MTeacher("Анна", "Дружинина", "Григорьевна", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher16);
            MTeacher mTeacher17 = new MTeacher("Алексей", "Зеленцов", "Вениаминович", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher17);
            MTeacher mTeacher18 = new MTeacher("Сергей", "Бушуев", "Герольдович", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher18);
            MTeacher mTeacher19 = new MTeacher("Жанна", "Дорохова", "Викторовна", " ", " ", " ", "Пн, Чт", "ПТ", "СБ, ВС");
            CTeacher.Insert(mTeacher19);
            #endregion

            #region institute
            MInstitute mInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Иванов Иван Иванович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute);

            MInstitute mInstitute1 = new MInstitute("Институт педагогики и психологии", "ИПП", "Аристархов Валерий Аристархович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute1);

            MInstitute mInstitute2 = new MInstitute("Институт физико математических и естественных наук", "ИФМЕН", "Михайлов Василий Александрович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute2);

            MInstitute mInstitute3 = new MInstitute("Институт дополнительного профессионального образования", "ИДПО", "Бекенева Любовь Александровна", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute3);

            MInstitute mInstitute4 = new MInstitute("Институт профессионального развития", "ИПР", "Селиванова Лариса Ивановна", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute4);

            MInstitute mInstitute5 = new MInstitute("Институт управления экономики и финансов", "ИУЭФ", "Беркович Маргарита Израйлевна", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute5);

            MInstitute mInstitute6 = new MInstitute("Институт гуманитарных наук и социальных технолоний", "ИГНиСТ", "Панкратова Ольга Борисовна", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute6);

            MInstitute mInstitute7 = new MInstitute("Институт дизайна и технологий", "ИДТ", "Шорохов Сергей Александрович", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute7);

            MInstitute mInstitute8 = new MInstitute("Юридический институт им. Ю. П. Новицкого", "ЮИН", "Бриль Геннадий Геннадьевич", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute8);

            MInstitute mInstitute9 = new MInstitute("Институт культуры и искуств", "ИКИ", "Домахина Надежда Михайловна", "Костромской Государственный Университет");
            CInstitute.Insert(mInstitute9);

            #endregion

            #region direction
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4, "ИАСТ");
            CDirectionOfPreparation.Insert(mDirectionOfPreparation);
            MDirectionOfPreparation mDirectionOfPreparation1 = new MDirectionOfPreparation("09.03.03", "Прикладная информатика", 4, "ИПР");
            CDirectionOfPreparation.Insert(mDirectionOfPreparation1);
            MDirectionOfPreparation mDirectionOfPreparation2 = new MDirectionOfPreparation("09.03.01", "Информатика и вычислительная техника", 4, "ИАСТ");
            CDirectionOfPreparation.Insert(mDirectionOfPreparation2);
            MDirectionOfPreparation mDirectionOfPreparation3 = new MDirectionOfPreparation("09.03.05", "Дизайн и технологии", 3, "ИДТ");
            CDirectionOfPreparation.Insert(mDirectionOfPreparation3);
            MDirectionOfPreparation mDirectionOfPreparation4 = new MDirectionOfPreparation("09.03.10", "Основы колористики", 3, "ИДТ");
            CDirectionOfPreparation.Insert(mDirectionOfPreparation4);
            #endregion

            #region TrainingProfile
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            CTrainingProfile.Insert(mTrainingProfile);
            MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Прикладная информатика", "ПИ", "09.03.03");
            CTrainingProfile.Insert(mTrainingProfile1);
            MTrainingProfile mTrainingProfile2 = new MTrainingProfile("Информатика и вычислительная техника", "ИВТ", "09.03.01");
            CTrainingProfile.Insert(mTrainingProfile2);
            MTrainingProfile mTrainingProfile3 = new MTrainingProfile("Дизайн и технологии", "ДИТ", "09.03.05");
            CTrainingProfile.Insert(mTrainingProfile3);
            #endregion

            #region group
            MGroup mGroup = new MGroup("17-ИСбо-2а", 4, "ИС", 1, 20, 2, 5, "Суббота");
            CGroup.Insert(mGroup);
            MGroup mGroup1 = new MGroup("17-ПИбо-4а", 5, "ПИ", 2, 19, 2, 5, "Воскресенье");
            CGroup.Insert(mGroup1);
            MGroup mGroup2 = new MGroup("17-ВТбо-2б", 4, "ИВТ", 1, 20, 2, 5, "Суббота");
            CGroup.Insert(mGroup2);
            MGroup mGroup3 = new MGroup("18-ИСбо-1а", 3, "ДИТ", 1, 20, 2, 5, "Суббота");
            CGroup.Insert(mGroup3);
            #endregion

            #region discipline
            MDiscipline mDiscipline = new MDiscipline("ВЕБ-программирование", "Web", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline);

            MDiscipline mDiscipline1 = new MDiscipline("Правоведение", "Право", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline1);

            MDiscipline mDiscipline2 = new MDiscipline("Системное ПО", "ПО", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline2);

            MDiscipline mDiscipline3 = new MDiscipline("Управление данными", "УД", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline3);

            MDiscipline mDiscipline4 = new MDiscipline("3Д-моделирование", "3D", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline4);

            MDiscipline mDiscipline5 = new MDiscipline("Моделирование ИС", "ИС", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline5);

            MDiscipline mDiscipline6 = new MDiscipline("Физическая культура и спорт", "Физра", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline6);

            MDiscipline mDiscipline7 = new MDiscipline("Моделирование информационных систем", "МИС", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline7);

            MDiscipline mDiscipline8 = new MDiscipline("Лингвистическое обеспечение Пр.Ап.Ср.", "ЛО", "Сентябрь-Декабрь");
            CDiscipline.Insert(mDiscipline8);

            MDiscipline mDiscipline9 = new MDiscipline("Программирование на языках высокого уровня", "ПЯВУ", "Январь-Март");
            CDiscipline.Insert(mDiscipline9);

            #endregion

            #region occupations
            MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations("Практика", "Практика");
            CTypesOfOccupations.Insert(mTypesOfOccupations);

            MTypesOfOccupations mTypesOfOccupations1 = new MTypesOfOccupations("Лекция", "Лекция");
            CTypesOfOccupations.Insert(mTypesOfOccupations1);
            #endregion

            #region AcademicLoad
            InitAcademicLoad();
            #endregion

            #region Schedule
            InitSchedule();
            #endregion

        }

        /// <summary>
        /// Заполняет нагрузку
        /// </summary>
        private void InitAcademicLoad()
        {
            CAcademicLoad.Insert(new MAcademicLoad(1, "17-ВТбо-2б", "72", "Управление данными", "Прядкина Нина Олеговна", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(2, "17-ВТбо-2б", "72", "Управление данными", "Прядкина Нина Олеговна", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(3, "17-ВТбо-2б", "36", "Программирование на языках высокого уровня", "Гутман Александр Сергеевич", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(4, "17-ВТбо-2б", "72", "Программирование на языках высокого уровня", "Гутман Александр Сергеевич", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(5, "17-ВТбо-2б", "72", "Моделирование ИС", "Панин Игорь Григорьевич", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(6, "17-ВТбо-2б", "72", "Моделирование ИС", "Чувиляева Александра Сергеевна", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(7, "17-ВТбо-2б", "36", "Лингвистическое обеспечение Пр.Ап.Ср.", "Орлов Александр Валерьевич", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(8, "17-ВТбо-2б", "72", "Лингвистическое обеспечение Пр.Ап.Ср.", "Орлов Александр Валерьевич", "Практика", "0"));

            CAcademicLoad.Insert(new MAcademicLoad(9, "17-ПИбо-4а", "72", "Моделирование ИС", "Панин Игорь Григорьевич", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(10, "17-ПИбо-4а", "72", "Моделирование ИС", "Чувиляева Александра Сергеевна", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(11, "17-ПИбо-4а", "36", "Лингвистическое обеспечение Пр.Ап.Ср.", "Орлов Александр Валерьевич", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(12, "17-ПИбо-4а", "72", "Лингвистическое обеспечение Пр.Ап.Ср.", "Орлов Александр Валерьевич", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(13, "17-ПИбо-4а", "144", "Физическая культура и спорт", "Бушуев Сергей Герольдович", "Практика", "0"));

            CAcademicLoad.Insert(new MAcademicLoad(14, "17-ВТбо-2б", "36", "ВЕБ-программирование", "Демчинова Елена Александровна", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(15, "17-ВТбо-2б", "72", "ВЕБ-программирование", "Демчинова Елена Александровна", "Практика", "0"));

            CAcademicLoad.Insert(new MAcademicLoad(16, "17-ИСбо-2а", "36", "Правоведение", "Зеленцов Алексей Вениаминович", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(17, "17-ИСбо-2а", "36", "Правоведение", "Зеленцов Алексей Вениаминович", "Практика", "0"));

            CAcademicLoad.Insert(new MAcademicLoad(18, "17-ВТбо-2б", "144", "Физическая культура и спорт", "Бушуев Сергей Герольдович", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(19, "17-ВТбо-2б", "72", "3Д-моделирование", "Дорохова Жанна Викторовна", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(20, "17-ВТбо-2б", "72", "Системное ПО", "Дружинина Анна Григорьевна", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(21, "17-ВТбо-2б", "72", "Системное ПО", "Дружинина Анна Григорьевна", "Практика", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(22, "17-ВТбо-2б", "36", "Правоведение", "Зеленцов Алексей Вениаминович", "Лекция", "0"));
            CAcademicLoad.Insert(new MAcademicLoad(23, "17-ВТбо-2б", "36", "Правоведение", "Зеленцов Алексей Вениаминович", "Практика", "0"));
        }

        /// <summary>
        /// Заполняем расписание тестовыми данными
        /// </summary>
        private void InitSchedule()
        {
            string[] days = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            // 17-ВТбо-2б
            CCourseSchedule.Insert(new MCourseSchedule(null, 1, "Е", "120", days[0], new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 6, "Е", "228", days[0], new TimeSpan(10, 10, 0), new TimeSpan(11, 40, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 19, "Е", "407", days[0], new TimeSpan(11, 50, 0), new TimeSpan(13, 20, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 5, "Е", "228", days[1], new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 18, "Е", "101", days[2], new TimeSpan(14, 0, 0), new TimeSpan(15, 30, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 2, "Е", "115", days[3], new TimeSpan(14, 0, 0), new TimeSpan(15, 30, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 7, "Е", "306", days[2], new TimeSpan(15, 40, 0), new TimeSpan(17, 10, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 22, "Б", "416", days[4], new TimeSpan(19, 0, 0), new TimeSpan(20, 30, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 23, "Б", "416", days[6], new TimeSpan(17, 20, 0), new TimeSpan(18, 50, 0)));

            // 17-ИСбо-2а
            CCourseSchedule.Insert(new MCourseSchedule(null, 17, "Е", "228", days[1], new TimeSpan(11, 50, 0), new TimeSpan(13, 20, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 16, "А", "303", days[3], new TimeSpan(10, 10, 0), new TimeSpan(11, 40, 0)));

            //17-ПИбо-4а
            CCourseSchedule.Insert(new MCourseSchedule(null, 13, "Е", "101", days[0], new TimeSpan(8, 30, 0), new TimeSpan(10, 0, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 9, "Е", "407", days[0], new TimeSpan(11, 50, 0), new TimeSpan(13, 20, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 10, "Е", "407", days[2], new TimeSpan(11, 50, 0), new TimeSpan(13, 20, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 12, "Е", "222", days[3], new TimeSpan(10, 10, 0), new TimeSpan(11, 40, 0)));
            CCourseSchedule.Insert(new MCourseSchedule(null, 11, "Е", "520", days[3], new TimeSpan(15, 40, 0), new TimeSpan(17, 10, 0)));
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

        /// <summary>
        /// Очистка таблиц от данных, в последовательности, определенной Relations
        /// Последовательность не менять - сломается очистка.
        /// </summary>
        public void ClearData()
        {
            CCourseSchedule.Clear();
            CAcademicLoad.Clear();
            CGroup.Clear();
            CTrainingProfile.Clear();
            CDirectionOfPreparation.Clear();
            CInstitute.Clear();
            CTeacher.Clear();
            CAuditor.Clear();
            CDiscipline.Clear();
            CTitle.Clear();
            CEnclosures.Clear();
            CUniversity.Clear();
            CStudyWeek.Clear();
            CAcademicDegree.Clear();
            CTypesOfOccupations.Clear();
            
        }
    }
}
