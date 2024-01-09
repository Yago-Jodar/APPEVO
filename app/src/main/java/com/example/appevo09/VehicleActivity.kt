package com.example.appevo09

// VehicleActivity.kt
import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.ImageButton
import android.widget.ImageView
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import com.google.gson.reflect.TypeToken
import org.json.JSONArray
import org.json.JSONException
import java.io.FileReader
import java.io.IOException

class VehicleActivity : AppCompatActivity() {

    private lateinit var vehicle: Vehicle

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.info_vehicle)



        val clickBack: ImageButton = findViewById(R.id.clickBack)
        clickBack.setOnClickListener {
            finish() // Finalizar la actividad actual
        }

        //vehicle = cargarVehiculoDesdeJSON("vehiculos_data.json", 0) ?: Vehicle()
        // Selecciona el primer vehículo (índice 0) o proporciona un objeto vacío

        mostrarInformacionVehiculo()
    }


    private fun cargarVehiculoDesdeJSON(fileName: String, indice: Int): Vehicle? {
        val jsonString = getVehicleFromJson()
        return try {
            val jsonArray = JSONArray(jsonString)
            val json = jsonArray.getJSONObject(indice)

            Vehicle(
                numInventari = json.optInt("numInventari"),
                ambit = json.optString("ambit"),
                colleccio = json.optString("colleccio"),
                nom = json.optString("nom"),
                llocFabricacio = json.optString("llocFabricacio"),
                procedencia = json.optString("procedencia"),
                fontEnergia = json.optString("fontEnergia"),
                potencia = json.optString("potencia"),
                formaIngres = json.optString("formaIngres"),
                fontIngres = json.optString("fontIngres"),
                multimedia = json.optJSONArray("multimedia")?.let {
                    val list = mutableListOf<String>()
                    for (i in 0 until it.length()) {
                        list.add(it.getString(i))
                    }
                    list
                } ?: mutableListOf(),
                descripcio = json.optString("descripcio"),
                any = json.optInt("any"),
                cicle = json.optInt("cicle"),
                cilindrada = json.optInt("cilindrada"),
                velocitatMax = json.optInt("velocitatMax"),
                velocitatCreuer = json.optInt("velocitatCreuer"),
                capacitatDeposit = json.optInt("capacitatDeposit"),
                llongitud = json.optDouble("llongitud")?.toFloat(),
                alcada = json.optDouble("alcada")?.toFloat(),
                envergadura = json.optDouble("envergadura")?.toFloat())
        } catch (e: JSONException) {
            e.printStackTrace()
            null
        }
    }

    private fun getVehicleFromJson(): MutableList<Vehicle> {
        val jsonFilePath = getFilesDir().toString() + "/json/ambits.json"
        val jsonFile = FileReader(jsonFilePath)
        val listVehiclesType = object : TypeToken<MutableList<Ambit>>() {}.type
        val vehicles: MutableList<Vehicle> = Gson().fromJson(jsonFile, listVehiclesType)
        return vehicles
    }

    private fun mostrarInformacionVehiculo() {
        val textViewNumInventari: TextView = findViewById(R.id.txtVehicleNumInventari)
        //val textViewAmbit: TextView = findViewById(R.id.txtAmbit)
        //val textViewColleccio: TextView = findViewById(R.id.textViewColleccio)
        val textViewNom: TextView = findViewById(R.id.txtNom)
        val textViewLlocFabricacio: TextView = findViewById(R.id.txtVehicleLlocDeFabricacio)
        val textViewProcedencia: TextView = findViewById(R.id.txtVehicleProcedencia)
        val textViewFontEnergia: TextView = findViewById(R.id.txtVehicleFontEnergia)
        val textViewPotencia: TextView = findViewById(R.id.txtVehiclePotencia)
        val textViewFormaIngres: TextView = findViewById(R.id.txtVehicleFormaIngres)
        val textViewFontIngres: TextView = findViewById(R.id.txtVehicleFontIngres)
        val textViewMultimedia: ImageView = findViewById(R.id.imgVehicleMultimedia)
        val textViewDescripcio: TextView = findViewById(R.id.txtVehicleDescripcio)
        val textViewAny: TextView = findViewById(R.id.txtVehicleAny)
        val textViewCicle: TextView = findViewById(R.id.txtVehicleCicle)
        val textViewCilindrada: TextView = findViewById(R.id.txtVehicleCilindrada)
        val textViewVelocitatMax: TextView = findViewById(R.id.txtVehicleVelocitatMax)
        val textViewVelocitatCreuer: TextView = findViewById(R.id.txtVehicleVelocitatCreuer)
        val textViewCapacitatDeposit: TextView = findViewById(R.id.txtVehicleCapacitatDeposit)
        val textViewLlongitud: TextView = findViewById(R.id.txtVehicleLlongitud)
        val textViewAlcada: TextView = findViewById(R.id.txtVehicleAlcada)
        val textViewEnvergadura: TextView = findViewById(R.id.txtVehicleEnvergadura)

        // Muestra u oculta TextViews según la disponibilidad de datos
        textViewNumInventari.visibility = View.VISIBLE
        //textViewAmbit.visibility = if (vehicle.ambit.isNullOrBlank()) View.GONE else View.VISIBLE
        //textViewColleccio.visibility = if (vehicle.colleccio.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewNom.visibility = View.VISIBLE
        textViewLlocFabricacio.visibility = if (vehicle.llocFabricacio.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewProcedencia.visibility = if (vehicle.procedencia.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewFontEnergia.visibility = if (vehicle.fontEnergia.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewPotencia.visibility = if (vehicle.potencia.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewFormaIngres.visibility = if (vehicle.formaIngres.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewFontIngres.visibility = if (vehicle.fontIngres.isNullOrBlank()) View.GONE else View.VISIBLE
        textViewDescripcio.visibility = View.VISIBLE
        textViewAny.visibility = View.VISIBLE
        textViewCicle.visibility = if (vehicle.cicle != 0) View.VISIBLE else View.GONE
        textViewCilindrada.visibility = if (vehicle.cilindrada != 0) View.VISIBLE else View.GONE
        textViewVelocitatMax.visibility = if (vehicle.velocitatMax != 0) View.VISIBLE else View.GONE
        textViewVelocitatCreuer.visibility = if (vehicle.velocitatCreuer != 0) View.VISIBLE else View.GONE
        textViewCapacitatDeposit.visibility = if (vehicle.capacitatDeposit != 0) View.VISIBLE else View.GONE
        textViewLlongitud.visibility = if (vehicle.llongitud != null && vehicle.llongitud != 0f) View.VISIBLE else View.GONE
        textViewAlcada.visibility = if (vehicle.alcada != null && vehicle.llongitud != 0f) View.VISIBLE else View.GONE
        textViewEnvergadura.visibility = if (vehicle.envergadura != null && vehicle.llongitud != 0f) View.VISIBLE else View.GONE


        // Configura el texto para los TextViews visibles
        textViewNom.text = if (!vehicle.nom.isNullOrBlank()) "Nom: ${vehicle.nom}" else ""


    }
}

