using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Filtering
    {
        public delegate bool PatientFilteredDelegate(Patient p, string searshValue);
        public HospitalQueue FilterPatients( Queue<Patient> patientsQueue, PatientFilteredDelegate filterDelegate, string searchValue)
        {
            // для хранения отфильтрованных пациентов
            var filteredQueue = new HospitalQueue();

            // провекра, есть ли пациенты в очереди
            if (patientsQueue.Count == 0)
            {
                MessageBox.Show("Очередь пациентов пуста. Нечего фильтровать.", "Пустая очередь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return filteredQueue;
            }

            // прроход по всем пациентам в началной очереди
            foreach (var patient in patientsQueue)
            {
                // отключаем вывод сообщений при добавлении
                filteredQueue.SetShowMessageOnAdd(false);

                // проверяем, подходит ли пациент по критериям 
                if (filterDelegate(patient, searchValue))
                {
                    // добавляем пациента
                    filteredQueue.AddPatient(patient);
                }
            }

            // провекрка, найдены ли пациенты
            if (filteredQueue._patientsQueue.Count == 0)
            {
                MessageBox.Show("Ни одного пациента не найдено по заданным критериям.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return filteredQueue;
        }
        //фильтрация по фамилии  с помощью лямда-функции
        public HospitalQueue FilterByLastName( HospitalQueue hospitalQueue, string searchValue)
        {
            return FilterPatients( hospitalQueue._patientsQueue, (patient, value) => patient.LastName.Contains(value), searchValue);
        }
        //фильтрация по имени  с помощью анонимного метода
        public HospitalQueue FilterByFirstName( HospitalQueue hospitalQueue, string searchValue)
        {
            HospitalQueue filteredQueue = FilterPatients( hospitalQueue._patientsQueue, delegate (Patient p, string search)
            {
                return p.FirstName.Contains(search);
            }, searchValue);
            return filteredQueue;
        }
    }
}
