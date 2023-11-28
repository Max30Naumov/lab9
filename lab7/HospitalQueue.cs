using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab7
{
    public class HospitalQueue
    {
        public Queue<Patient> _patientsQueue = new Queue<Patient>();        
        private bool _showMessageOnAdd = true;

        public void SetShowMessageOnAdd(bool show)
        {
            _showMessageOnAdd = show;
        }
        //метод для добавления пациента в очередь
        public void AddPatient(Patient patient)
        {
            if (patient is not null)
            {
                //проверка, что ID пациента  больше нуля
                if (patient.Id > 0)
                {
                    _patientsQueue.Enqueue(patient); // добавляем пациента в очередь
                    if (_showMessageOnAdd)
                        MessageBox.Show($"{patient.FirstName} {patient.LastName} добавлен в очередь.", "Добавление пациента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка. Проверьте ID пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Ошибка. Введите данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        //метод для удаления первого пациента из очереди 
        public void RemoveFirstPatient()
        {
            if (_patientsQueue.Count > 0)
            {
                Patient patientToRemove = _patientsQueue.Dequeue();               
                MessageBox.Show($"{patientToRemove.FirstName} {patientToRemove.LastName} удален з очереди.", "Удаление пациента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Очередь пуста. Нету пациентов для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //vетод для отображения текущей очереди пациентов
        public string DisplayQueue()
        {
            // создаем объект StringBuilder для построения строки
            StringBuilder result = new StringBuilder();
            result.AppendLine("Текущая очередь пациентов:");
            //прроходим по каждому пациенту в очереди
            foreach (var patient in _patientsQueue)
            {
                result.AppendLine($"Имя: {patient.FirstName} {patient.LastName}, Возраст: {patient.Age}, ID: {patient.Id}");
            }
            // переводимм объект StringBuilder в строку
            return result.ToString();
        }
     
      


    }
}

