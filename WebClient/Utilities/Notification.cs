namespace WebClient.Utilities;

public enum NotificationIcon { error, info, success, warning }

public class Notification
{
    public string Title { get; set; } = "Notification";
    public string Message { get; set; } = "";
    public string? ButtonText { get; set; } = null;
    public NotificationIcon Icon { get; set; } = NotificationIcon.info;
    public string IconColor => Icon switch 
    { 
        NotificationIcon.info => "var(--info)",
        NotificationIcon.success => "var(--success)",
        NotificationIcon.error => "var(--error)",
        NotificationIcon.warning => "var(--warning)",
    };

}