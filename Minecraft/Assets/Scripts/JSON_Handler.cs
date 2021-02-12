using UnityEngine;

public class JSON_Handler : MonoBehaviour
{
    public TextAsset JSON_file;
    [System.Serializable]
    public class Properties
    {
        public int distance;
        public string snowy;
        public string plant_type;
        public string type;
        public string persistent;
        public string color;
        public string check_decay;
        public string material;
        public string falling;
        public string flowing;
        public int level;
        public string facing;
        public string split;
        public string update;
        public string east;
        public string north;
        public string west;
        public string south;
        public string powered;
        public string half;
        public string occupied;
        public string part;
        public string has_record;

    }

    [System.Serializable]
    public class Voxel
    {
        public int[] axes;
        public string type;
        public Properties properties;
    }

    [System.Serializable]

    public class VoxelList
    {
        public Voxel[] list;
    }

    public VoxelList bedrock_Voxel_list = new VoxelList();

    private void Awake()
    {
        // Read data from Json file
        bedrock_Voxel_list = JsonUtility.FromJson<VoxelList>(JSON_file.text);
    }


    // public List<string> types;
    public void Start()
    {

       // Code to get the different type of blocks
       // For making materials

       /* bool is_there = false;
        foreach (var item in bedrock_Voxel_list.list)
        {
           
            foreach (string type in types)
            {
                if (type == item.type)
                {
                    is_there = true;
                }
              
            }
            if(!is_there)
            {
                types.Add(item.type);
            }
            is_there = false;
        }
       */
    }
}
