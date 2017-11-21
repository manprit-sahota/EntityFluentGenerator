using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.AvalonEdit;

namespace Splendid.POCO.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly TextEditor EntityEditor;
        private readonly TextEditor EntityMapEditor;
        public MainWindowViewModel(TextEditor entityEditor
            , TextEditor entityMapEditor)
        {
            EntityEditor = entityEditor;
            EntityMapEditor = entityMapEditor;
        }
    }
}
