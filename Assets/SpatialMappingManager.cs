using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

public class SpatialMappingManager : MonoBehaviour
{
    // Start is called before the first frame update

   /* static class observer
    {
        public static  IMixedRealitySpatialAwarenessMeshObserver observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();;
    }*/
    //bool m;
    // Mesh Observer Zugriff
   //public static IMixedRealitySpatialAwarenessMeshObserver observ = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
    void Start()
    {
      
        //CoreServices.SpatialAwarenessSystem.ResumeObservers();
       // Debug.Log("Hallo :) ");
    }

    //Startet das Spatial Mapping
    //In der Regel besitzt die Hololens 1 einen Observer (eingebaute Kamera),in Simulationen sind mehrere Obsever möglich
   public void meshObserverstarten(bool mode)
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        //  var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        if (mode == true && observer != null)
        {
            // Netz sichtbar machen
            //observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
            Debug.Log("true wird durchlaufen");
            
          
            // Starte Mesh Obsever
            observer.Resume();

            // CoreServices.SpatialAwarenessSystem.ResumeObservers();
        }
        else
        {
           // Netz nicht anzeigen
           // observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
            
        }



        Debug.Log("Funktion starten wird aufgerufen");
    
}
    //Stoppt das Spatial Mapping, die Hololens führt aber trotzdem weiterhin das Mapping aus, es wird aber nicht gespeichert im Mesh nach stoppen
    
    public void meshObserverStoppen(bool mode)
    {
        // Get the first Mesh Observer available, generally we have only one registered
        //  var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        if (mode == true)
        {
            
            Debug.Log("wird durchlaufen");

           // var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
            // mesh Observer stoppen
           
            CoreServices.SpatialAwarenessSystem.SuspendObservers();

        }
        else
        {
            Debug.Log("Fehler, Wert false");
        }



        Debug.Log("Funktion stoppen wird aufgerufen");

    }
    // Update is called once per frame
    void Update()
    {

    }
}




