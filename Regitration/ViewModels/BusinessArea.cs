using System;

namespace Regitration.ViewModels
{
    [Serializable]
    public class BusinessArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }
}