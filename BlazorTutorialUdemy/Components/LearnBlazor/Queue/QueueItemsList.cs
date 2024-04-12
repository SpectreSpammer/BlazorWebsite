using BlazorTutorialUdemy.Components.LearnBlazor.BindProperty_Checkbox;

namespace BlazorTutorialUdemy.Components.LearnBlazor.Queue
{
    public class QueueItemsList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isActive { get; set; }

        public List<QueueItems> QueueProperties { get; set; }
    }
}
