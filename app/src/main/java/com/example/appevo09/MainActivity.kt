package com.example.appevo09

import android.content.Intent
import android.os.Bundle
import android.os.Handler
import android.view.View
import android.widget.Button
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

    //Cambiar la UI de ámbitos cada cierto tiempo



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        ambits = getAmbitsFromJson()

        cambiarUI()


        //Botón para entrar de la UI de los ámbitos a la de vehículos.
        val botonEntrar: Button = findViewById(R.id.btnOK)

        botonEntrar.setOnClickListener {

            val intent = Intent(this, Vehicle::class.java)
            startActivity(intent)
        }


        //Cambiar de idioma.
        val idiomas = listOf("Catalán", "Español", "Inglés")
        val banderas = listOf(R.drawable.bandera_cat, R.drawable.bandera_es, R.drawable.bandera_uk)

        val adapter = SpinnerIdiomas(this, idiomas, banderas)

        val spinner: Spinner = findViewById(R.id.spinnerIdiomas1)
        spinner.adapter = adapter


    }

    fun getAmbitsFromJson(): MutableList<Ambit> {
        // Nombre del archivo JSON que se encuentra en el directorio 'assets'
        val jsonName = "ambitos.json"

        try {
            // Abre un InputStream para leer el archivo JSON desde el directorio 'assets'
            val inputStream = assets.open(jsonName)

            // Crea un lector InputStreamReader para leer el contenido del InputStream
            val reader = InputStreamReader(inputStream)

            // Especifica el tipo de lista que Gson debe deserializar
            val listAmbitsType = object : TypeToken<MutableList<Ambit>>() {}.type

            // Utiliza Gson para deserializar el contenido del archivo JSON a una lista de objetos Ambit
            return Gson().fromJson(reader, listAmbitsType)
        } catch (e: Exception) {
            // Maneja cualquier excepción que pueda ocurrir durante la lectura o deserialización
            e.printStackTrace()

            // En caso de error, devuelve una lista vacía para evitar problemas adicionales
            return mutableListOf()
        }
    }



    //Cambiar la UI de un ámbito a otro.
    fun cambiarUI() {

        val ambitoActual = ambits [indiceActual]

        // Accede a los elementos de la interfaz de usuario por sus ID y actualiza la información
        val txtTitle: TextView = findViewById(R.id.txtTitlePrincipal)
        val background_image: ImageView = findViewById(R.id.background_image)
        val txtDescription: TextView = findViewById(R.id.txtDescription)

        txtTitle.text = ambitoActual.title
        background_image.setImageResource(ambitoActual.image)
        txtDescription.text = ambitoActual.description
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
