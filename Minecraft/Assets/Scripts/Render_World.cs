using UnityEngine;

public class Render_World : MonoBehaviour
{
    private JSON_Handler json_data;
    public GameObject CubePrefab;
    public Object[] Materials;
    public GameObject ParentObject;

    public void Awake()
    {
        json_data = gameObject.GetComponent<JSON_Handler>();
    }

    public void Start()
    {
        // Load all materials from folder "/Resources/Material"
        Materials = Resources.LoadAll("Material", typeof(Material));

        //loop through all entries in Json data and spawn block at each position
        foreach (var item in json_data.bedrock_Voxel_list.list)
        {
            // Ignores the blocks with air type
              if (item.type != "air")
              {
                  GameObject Cube_clone;
                  Cube_clone = Instantiate(CubePrefab,ParentObject.transform);
                  Cube_clone.transform.position = new Vector3(item.axes[0], item.axes[1], item.axes[2]);
                  Material Cube_mat = null;
                 
                 // Search for the block material by its name 
                 // Name of the materials in folder should be same as the types of block in Json file
                  foreach (Object mat in Materials)
                  {
                      if (mat.name == item.type)
                      {
                          Cube_mat = (Material)mat;
                      }
                  }
                  Cube_clone.GetComponent<MeshRenderer>().material = Cube_mat;
              } 
        }
    }
}
