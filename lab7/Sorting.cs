using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Sorting
    {    

        public delegate int PatientComparisonDelegate(Patient p1, Patient p2);
        private void SortPatients(Queue<Patient> patientsQueue, PatientComparisonDelegate comparisonDelegate)
        {
            // Проверка, что в очереди есть элементы для сортировки
            if (patientsQueue.Count > 0)
            {
                // Копирование элементов очереди в список для сортировки
                List<Patient> sortedList = patientsQueue.ToList();

                // Сортировка списка пациентов с использованием переданного делегата сравнения
                sortedList.Sort((p1, p2) => comparisonDelegate(p1, p2));

                // Очистка исходной очереди
                patientsQueue.Clear();

                // Перенос отсортированных элементов обратно в очередь
                foreach (var patient in sortedList)
                {
                    patientsQueue.Enqueue(patient);
                }
            }
            else
            {
                // Вывод сообщения об ошибке, если очередь пуста
                MessageBox.Show("Очередь пациентов пуста. Данные не будут отсортированы.", "Пустая очередь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //сортировка по id возрастанию с помощью лямда-функции
        public void SortByIdAscending( HospitalQueue hospitalQueue)
        {
            SortPatients( hospitalQueue._patientsQueue, (p1, p2) => p1.Id.CompareTo(p2.Id));
        }
        //сортировка по id по убыванию с помощью лямда-функции
        public void SortByIdDescending( HospitalQueue hospitalQueue)
        {
            SortPatients( hospitalQueue._patientsQueue, (p1, p2) => p2.Id.CompareTo(p1.Id)); 
        }
        //сортировка по возрасту по возрастанию с помощью анонимного метода
        public void SortByAgeAscending( HospitalQueue hospitalQueue)
        {
            SortPatients( hospitalQueue._patientsQueue, delegate (Patient p1, Patient p2)
            {
                return p1.Age.CompareTo(p2.Age);
            });
        }
        //сортировка по возрасту по убыванию с помощью анонимного метода
        public void SortByAgeDescending( HospitalQueue hospitalQueue)
        {
            SortPatients( hospitalQueue._patientsQueue, delegate (Patient p1, Patient p2)
            {
                return p2.Age.CompareTo(p1.Age);
            });
        }
       
    }
}