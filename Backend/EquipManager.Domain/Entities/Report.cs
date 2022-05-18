using EquipManager.Domain.Enums;

namespace EquipManager.Domain.Entities
{
    public abstract class Report
    {
        protected Report(Borrows borrow, DateTime date, EBorrowType type)
        {
            Borrow = borrow;
            Date = date;
            Type = type;
        }

        public Borrows Borrow { get; private set; }
        public DateTime Date { get; private set; }
        public EBorrowType Type { get; private set; }
    }

}