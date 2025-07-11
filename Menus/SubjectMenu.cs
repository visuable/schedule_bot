using schedule_bot.Menus;

namespace schedule_bot.Menus;

public class SubjectMenuSnapshot : MenuSnapshot;
public class SubjectMenu : InlineMenu
{
    public SubjectMenu(IEnumerable<string> subjects)
    {
        
    }

    public override MenuSnapshot CreateSnapshot() => new SubjectMenuSnapshot();
}