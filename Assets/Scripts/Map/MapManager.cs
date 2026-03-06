// Quản lý bố cục bản đồ và khu vực

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Danh sách các khu vực trên bản đồ
    private List<Zone> zones;

    void Start()
    {
        // Khởi tạo danh sách khu vực
        zones = new List<Zone>();
        LoadMapLayout();
    }

    void LoadMapLayout()
    {
        // Tải cấu hình bản đồ từ một nguồn nào đó
        // ...
    }

    // Hàm thêm khu vực mới vào bản đồ
    public void AddZone(Zone newZone)
    {
        zones.Add(newZone);
    }

    // Hàm lấy thông tin khu vực
    public Zone GetZone(int index)
    {
        if (index >= 0 && index < zones.Count)
        {
            return zones[index];
        }
        return null; // Nếu không tìm thấy khu vực
    }
}

[System.Serializable]
public class Zone
{
    public string name;
    public Vector3 position;
    public Vector3 size;
}