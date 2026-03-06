// Lớp GameManager để quản lý vòng lặp trò chơi và logic trò chơi chính

public class GameManager : MonoBehaviour
{
    private bool isGameRunning;

    // Khởi tạo trò chơi
    void Start()
    {
        isGameRunning = true;
        Debug.Log("Trò chơi bắt đầu!");
    }

    // Vòng lặp trò chơi
    void Update()
    {
        if (isGameRunning)
        {
            // Logic xử lý vòng lặp trò chơi
            Debug.Log("Đang chơi...");
        }
    }

    // Kết thúc trò chơi
    public void EndGame()
    {
        isGameRunning = false;
        Debug.Log("Trò chơi đã kết thúc!");
    }
}