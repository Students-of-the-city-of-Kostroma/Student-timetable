using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// ������� ������� ������ �� ������ ������� ��������
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
            Assert.AreEqual(refData.CEnclosures.Rows.Count == 0, true, "��� �������� ���������� ������� � ������� ��������, ��� ��������� �� ������");
            MUniversity grUni = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "��� ������� �������� ����������� � ������� � ��������������, �� �� ��� ��������");
            MEnclosures gr = new MEnclosures("�", grUni.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr), false, "������ ��� �����, �� ������ �� ��, ��� ������� � ��������� �����");
        }
        /// <summary>
        /// ������� ������� ������ �� ������� �������� ��� �� ����������� ��������� ��������
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            MUniversity grUni = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "��� ������� �������� ����������� � ������� � ��������������, �� �� ��� ��������");
            MEnclosures gr = new MEnclosures("�", grUni.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "��� ������� �������� ������ � ������� � ���������, �� �� ��� ��������");
            MUniversity grUni2 = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("�", grUni2.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false, "������ ��� �����, �� ������ �� ��, ��� �������� �������� �� ���������");
        }
        /// <summary>
        /// ������� ������� ������ �� ������� �������� ��� �� ����������� ��������� �������� �������������
        /// </summary>
        [TestMethod]
        public void Task_395_3()
        {
            MUniversity grUni = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "��� ������� �������� ����������� � ������� � ��������������, �� �� ��� ��������");
            MEnclosures gr = new MEnclosures("�", grUni.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "��� ������� �������� ������ � ������� � ���������, �� �� ��� ��������");
            MUniversity grUni2 = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("�", grUni2.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false, "������ ��� �����, �� ������ �� ��, ��� �������� ������������� �� ���������");
        }
        /// <summary>
        /// ������� ������� ������ �� ������� �������� ��� ���� ����������� ���������
        /// </summary>
        [TestMethod]
        public void Task_395_4()
        {
            MUniversity grUni = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "��� ������� �������� ����������� � ������� � ��������������, �� �� ��� ��������");
            MEnclosures gr = new MEnclosures("�", grUni.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "��� ������� �������� ������ � ������� � ���������, �� �� ��� ��������");
            MUniversity grUni2 = new MUniversity("4401906286", "���", "����������� ��������������� �����������", "159005, ����������� �������, �. ��������, ��. ������������, 27", "158005, ����������� �������, �. ��������, ��. ������������, 47", "���������", "������", "�����������", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("�", grUni2.FullName, "������������", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), true, "������ �� ��� �����, �� ������ �� ��, ��� ��� ���� ���������");
        }
    }
}