package com.example.appevo09

import android.content.Intent
import android.graphics.BitmapFactory
import android.os.Bundle
import android.os.Handler
import android.view.View
import android.widget.Button
import android.widget.ImageButton
import android.widget.ImageView
import android.widget.Spinner
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import com.google.gson.reflect.TypeToken
import java.io.FileReader
import java.io.InputStreamReader

class MainActivity : AppCompatActivity() {

    lateinit var ambits: MutableList<Ambit>

    //Posición inicial del ámbito
    var indiceActual = 0

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        ambits = getAmbitsFromJson()

        if (ambits.isNotEmpty()) {
            cambiarUI()
        }


        //Botón para entrar de la UI de los ámbitos a la de vehículos.
        val botonEntrar: Button = findViewById(R.id.btnOK)

        botonEntrar.setOnClickListener {

            // Crear un Intent para pasar de MainActivity a VehicleActivity
            val intent = Intent(this@MainActivity, VehicleActivity::class.java)

            // Iniciar la nueva actividad
            startActivity(intent)
        }


    }

    fun getAmbitsFromJson(): MutableList<Ambit> {
        val jsonFilePath = getFilesDir().toString() + "/json/ambits.json"
        val jsonFile = FileReader(jsonFilePath)
        val listAmbitsType = object : TypeToken<MutableList<Ambit>>() {}.type
        val ambits: MutableList<Ambit> = Gson().fromJson(jsonFile, listAmbitsType)
        return ambits
    }

    //Cambiar la UI de un ámbito a otro.
    fun cambiarUI() {

        if (ambits.isNotEmpty()) {
            val ambitoActual = ambits[indiceActual]

            // Accede a los elementos de la interfaz de usuario por sus ID y actualiza la información
            val txtTitle: TextView = findViewById(R.id.txtTitlePrincipal)
            val background_image: ImageView = findViewById(R.id.background_image)
            val txtDescription: TextView = findViewById(R.id.txtDescription)

            txtTitle.text = ambitoActual.title

            //Importar imagen de los archivos
            val ambitPath = getFilesDir().toString() + "/img/ambits/" + ambitoActual.multimedia
            val bitmap = BitmapFactory.decodeFile(ambitPath)
            background_image.setImageBitmap(bitmap)

            //background_image.setImageResource(ambitoActual.image)

            txtDescription.text = ambitoActual.description
        }
    }

    // Método para manejar el botón siguiente
    fun onSiguienteClick(view: View) {
        if (indiceActual < ambits.size - 1) {
            indiceActual++
            cambiarUI()
        }
    }

    // Método para manejar el botón anterior
    fun onAnteriorClick(view: View) {
        if (indiceActual > 0) {
            indiceActual--
            cambiarUI()
        }
    }
}
