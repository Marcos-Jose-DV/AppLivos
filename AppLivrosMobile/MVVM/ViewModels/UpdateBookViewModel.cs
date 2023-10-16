
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class UpdateBookViewModel : ObservableObject, IQueryAttributable
{
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var id = query["id"];
    }
}
