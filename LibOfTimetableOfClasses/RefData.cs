using System.Data;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// В этом классе храняться все экземпляры контроллеров.
    /// </summary>
    public class RefData
    {
        public static DataSet DataSet = new DataSet();
        public static CTeacher CTeacher = new CTeacher();
        public static CAuditor CAuditor = new CAuditor();
        public static CDiscipline CDiscipline = new CDiscipline();
        public static CGroup CGroup = new CGroup();
        public static CTitle CTitle = new CTitle();
        public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
        public static CDirectionOfPreparation CDirectionOfPreparation = new CDirectionOfPreparation();
        public static CEnclosures CEnclosures = new CEnclosures();
        public static CUniversity CUniversity = new CUniversity();
        public static CStudyWeek CStudyWeek = new CStudyWeek();
        public static CInstitute CInstitute = new CInstitute();
        public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
        public static CTypesOfOccupations CTypesOfOccupations = new CTypesOfOccupations();
        public static CAcademicLoad CAcademicLoad = new CAcademicLoad();
#pragma warning disable IDE0044 // Добавить модификатор только для чтения
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены
        private static RefData rd = new RefData();
#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены
#pragma warning restore IDE0044 // Добавить модификатор только для чтения
        private RefData()
        {
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
            DataSet.Tables.Add(CAcademicLoad);

            DataSet.Relations.Add("Direction_TrainingProfile", CDirectionOfPreparation.Columns["CodeOfDP"], CTrainingProfile.Columns["Shiphr"]);
            DataSet.Relations.Add("Enclosures-Auditor", CEnclosures.Columns["Name"], CAuditor.Columns["Building"]);
            DataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"]);
            DataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["academicTitle"]);
            DataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
            DataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);
            DataSet.Relations.Add("Group-Training profile", CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
            DataSet.Relations.Add("University-Enclosures", CUniversity.Columns["FullName"], CEnclosures.Columns["University"]);
            DataSet.Relations.Add("AcademicLoad-Group", CAcademicLoad.Columns["Group"], CGroup.Columns["Group"]);
            DataSet.Relations.Add("AcademicLoad-Discipline", CAcademicLoad.Columns["Discipline"], CDiscipline.Columns["FullName"]);
            DataSet.Relations.Add("AcademicLoad-Teacher", CAcademicLoad.Columns["Professor"], CTeacher.Columns["FullName"]);
            DataSet.Relations.Add("AcademicLoad-TypesOfOccupations", CAcademicLoad.Columns["KindOfLesson"], CTypesOfOccupations.Columns["FullName"]);
            init();
        }
        private void init()
        {
            #region direction
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4);
            RefData.CDirectionOfPreparation.Insert(mDirectionOfPreparation);
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            RefData.CTrainingProfile.Insert(mTrainingProfile);
            MGroup mGroup = new MGroup("17-ИСбо-2а", 4, "ИС", 1, 20, 2, 5, "Суббота");
            RefData.CGroup.Insert(mGroup);

            MDirectionOfPreparation mDirectionOfPreparation1 = new MDirectionOfPreparation("09.03.03", "Прикладная информатика", 4);
            RefData.CDirectionOfPreparation.Insert(mDirectionOfPreparation1);
            MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Прикладная информатика", "ПИ", "09.03.03");
            RefData.CTrainingProfile.Insert(mTrainingProfile1);
            MGroup mGroup1 = new MGroup("17-ПИбо-4а", 5, "ПИ", 2, 19, 2, 5, "Воскресенье");
            RefData.CGroup.Insert(mGroup1);

            MDirectionOfPreparation mDirectionOfPreparation2 = new MDirectionOfPreparation("09.03.01", "Информатика и вычислительная техника", 4);
            RefData.CDirectionOfPreparation.Insert(mDirectionOfPreparation2);
            MTrainingProfile mTrainingProfile2 = new MTrainingProfile("Информатика и вычислительная техника", "ИВТ", "09.03.01");
            RefData.CTrainingProfile.Insert(mTrainingProfile2);
            MGroup mGroup2 = new MGroup("17-ВТбо-2б", 4, "ИВТ", 1, 20, 2, 5, "Суббота");
            RefData.CGroup.Insert(mGroup2);
            #endregion
            #region discipline
            MDiscipline mDiscipline = new MDiscipline("Математика", "Мат", "Окт-Янв");
            RefData.CDiscipline.Insert(mDiscipline);

            MDiscipline mDiscipline1 = new MDiscipline("Физика", "Физ", "Янв-Март");
            RefData.CDiscipline.Insert(mDiscipline1);

            MDiscipline mDiscipline2 = new MDiscipline("Приграммирование", "Прг", "Янв-Май");
            RefData.CDiscipline.Insert(mDiscipline2);
            #endregion
            #region academicdegree
            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            RefData.CAcademicDegree.Insert(mAcademicDegree);
            MTitle mTitle = new MTitle("Доцент", "Доц");
            RefData.CTitle.Insert(mTitle);
            MTeacher mTeacher = new MTeacher("Иван", "Иванов", "Иванович", "КН", "Доц", "ИАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            RefData.CTeacher.Insert(mTeacher);

            MAcademicDegree mAcademicDegree1 = new MAcademicDegree("Доктор наук", "ДН");
            RefData.CAcademicDegree.Insert(mAcademicDegree1);
            MTitle mTitle1 = new MTitle("Профессор", "Проф");
            RefData.CTitle.Insert(mTitle1);
            MTeacher mTeacher1 = new MTeacher("Василий", "Михайлов", "Александрович", "ДН", "Проф", "ИФМЕН", "Вт, Чт", "ПН, ПТ", "СБ, ВС");
            RefData.CTeacher.Insert(mTeacher1);

            MAcademicDegree mAcademicDegree2 = new MAcademicDegree("Кандидат наук", "КН");
            RefData.CAcademicDegree.Insert(mAcademicDegree2);
            MTitle mTitle2 = new MTitle("Профессор", "Проф");
            RefData.CTitle.Insert(mTitle2);
            MTeacher mTeacher2 = new MTeacher("Валерий", "Аристархов", "Аристархович", "КН", "Проф", "ИПП", "Пн, Чт", "ПТ", "СБ, ВС");
            RefData.CTeacher.Insert(mTeacher2);
            #endregion
            #region university
            MUniversity mUniversity = new MUniversity("4401006286", "КГУ", "Костромской Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Рудольфович", "Наумов", "info@kstu.edu.ru", "84942317960");
            RefData.CUniversity.Insert(mUniversity);

            MUniversity mUniversity1 = new MUniversity("7604011791", "ЯГУ", "Ярославский Государственный Университет", "150003, Ярославская область, г. Ярославль, ул. Советская, 14", "150003, Ярославская область, г. Ярославль,ул. Советская, 14", "Михаил", "Михайлович", "Котюков", "rectorat@uniyar.ac.ru", "84852797702");
            RefData.CUniversity.Insert(mUniversity1);

            MUniversity mUniversity2 = new MUniversity("7605009467", "ЯГТУ", "Ярославский Государственный Технический Университет", "150023, Ярославская область, г. Ярославль, ул. Московский пр., 88", "150023, Ярославская область, г. Ярославль, ул. Московский пр., 88", "Елена", "Олеговна", "Степанова", "rector@ystu.ru", "84852305661");
            RefData.CUniversity.Insert(mUniversity2);
            #endregion
            #region enclosures
            MEnclosures mEnclosures = new MEnclosures("Е", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 4", "84942536522", "Примечание");
            RefData.CEnclosures.Insert(mEnclosures);

            MEnclosures mEnclosures1 = new MEnclosures("А", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 6", "88005534535", "Примечание");
            RefData.CEnclosures.Insert(mEnclosures1);

            MEnclosures mEnclosures2 = new MEnclosures("Б", "Костромской Государственный Университет", "г. Кострома, Малышковская ул., 8", "84947004444", "Примечание");
            RefData.CEnclosures.Insert(mEnclosures2);
            #endregion
            #region institute
            MInstitute mInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Иванов Иван Иванович", "Костромской Государственный Университет");
            RefData.CInstitute.Insert(mInstitute);

            MInstitute mInstitute1 = new MInstitute("Институт педагогики и психологии", "ИПП", "Аристархов Валерий Аристархович", "Костромской Государственный Университет");
            RefData.CInstitute.Insert(mInstitute1);

            MInstitute mInstitute2 = new MInstitute("Институт физико математических и естественных наук", "ИФМЕН", "Михайлов Василий Александрович", "Костромской Государственный Университет");
            RefData.CInstitute.Insert(mInstitute2);
            #endregion
            #region auditor
            MAuditor mAuditor = new MAuditor("325", "Информационные системы", 100, "Е");
            RefData.CAuditor.Insert(mAuditor);

            MAuditor mAuditor1 = new MAuditor("214", "Педагогики", 80, "А");
            RefData.CAuditor.Insert(mAuditor1);

            MAuditor mAuditor2 = new MAuditor("123", "Философии", 77, "Б");
            RefData.CAuditor.Insert(mAuditor2);
            #endregion
            #region occupations
            MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations("Технология разработки программного обеспичения", "ТРПО");
            RefData.CTypesOfOccupations.Insert(mTypesOfOccupations);

            MTypesOfOccupations mTypesOfOccupations1 = new MTypesOfOccupations("Теория информационных процессов и систем", "ТИПИС");
            RefData.CTypesOfOccupations.Insert(mTypesOfOccupations1);

            MTypesOfOccupations mTypesOfOccupations2 = new MTypesOfOccupations("Инфокоммуникационные системы и сети", "ИСС");
            RefData.CTypesOfOccupations.Insert(mTypesOfOccupations2);
            #endregion
        }
    }
}
