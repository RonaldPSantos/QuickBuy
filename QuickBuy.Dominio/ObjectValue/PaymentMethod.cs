using QuickBuy.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjectValue
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TypePaymentMethodEnum.Boleto; }
        }
        public bool EhCartao
        {
            get { return Id == (int)TypePaymentMethodEnum.Boleto; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TypePaymentMethodEnum.Boleto; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TypePaymentMethodEnum.Indefinido; }
        }
    }
}
