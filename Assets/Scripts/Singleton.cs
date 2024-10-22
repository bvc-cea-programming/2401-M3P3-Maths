using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour
{
    private static T _instance;

    public static T instance
    {
        get
        {
            if(Equals(_instance, null) || _instance == null || _instance.Equals(null))
            {
                var instanceObject = FindObjectOfType<Singleton<T>>();
                _instance = instanceObject.GetComponent<T>();
            }

            return _instance;
        }
        set 
        {
            _instance = value;
        }
    }

    protected void InitSingleton(T singletonInstance)
    {
        /*var instancesOfThisSingleton = FindObjectsOfType<Singleton<T>>();
        if(instancesOfThisSingleton.Length > 1)
        {
            Destroy(this.gameObject);
            return;
        }
        
        if(_instance == null)
            _instance = singletonInstance;
        else if (_instance.Equals(singletonInstance))
            Destroy(this.gameObject);*/
        if (_instance == null)
            _instance = singletonInstance;
        else
            Destroy(this.gameObject);
    }
}
