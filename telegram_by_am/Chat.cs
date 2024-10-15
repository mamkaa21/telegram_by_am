using System;
using System.Collections.Generic;

namespace telegram_by_am;

public partial class Chat
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public string Author { get; set; } = null!;
}
