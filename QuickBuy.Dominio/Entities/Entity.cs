using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entity
    {
        public List<string> _messageValidation { get; set; }

        private List<string> messageValidation
        {
            get { return _messageValidation ?? (_messageValidation = new List<string>()); }
        }

        protected void ClearMessagesValidation()
        {
            messageValidation.Clear();
        }

        protected void AddReview(string message)
        {
            messageValidation.Add(message);
        }

        public abstract void Validate();

        protected bool isValid
        {
            get { return !messageValidation.Any(); }
        }

    }
}
