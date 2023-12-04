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


class MainActivity : AppCompatActivity() {

    lateinit var listaAmbitos: List<Ambit>

    //Posición inicial del ámbito
    var indiceActual = 0

    //Cambiar la UI de ámbitos cada cierto tiempo


    //Lista de ambitos.
    var ambits = mutableListOf( Ambit("Els inicis de l'aviació", "L’any 1903 els germans Wright van aconseguir volar amb un aparell tripulat i\n" +
            "    autopropulsat. A Catalunya hi va haver dos intents seriosos en la construcció\n" +
            "    d'avions: el 1908 ho va intentar Gaspar Brunet a l'hipòdrom del Prat de\n" +
            "    Llobregat i Joan Oliver a la platja de la Malvarosa de València el 1909, però cap\n" +
            "    d'ells no va arribar a poder volar ni aterrar correctament. No va ser fins l'11 de\n" +
            "    febrer de 1910 que Lucien Mamet, amb un Blériot XI, va realitzar un vol de dos\n" +
            "    minuts i vint segons i 70 metres d'altura a l'hipòdrom de Can Tunis de\n" +
            "    Barcelona.", R.drawable.aviacion),
        Ambit("Transport de persones i mercaderies", "Podem dividir el transport de persones i mercaderies en tres categories:\n" +
                "La primera correspon al moviment de càrregues que depèn de l’energia\n" +
                "humana per desplaçar-se. Per una banda, tenim les transportines, portades per\n" +
                "dos homes que subjectaven els quatre pals de fusta. Per l&#39;altra, tenim les\n" +
                "bicicletes, el primer sistema de transport propulsat sobre dues rodes.\n" +
                "El segon grup contempla tots aquells vehicles que poden desplaçar-se gràcies\n" +
                "a la utilització d&#39;animals domesticats com a força motriu. Les tartanes en són un\n" +
                "exemple, ja que permetien transportar persones, però estaven més emprades\n" +
                "per la càrrega de mercaderies. Fins al segle XIX, les tartanes i els carros\n" +
                "constituïen una part important de l&#39;oferta de transport de bens.\n" +
                "Finalment, tenim aquells vehicles que funcionen gràcies a l&#39;aprofitament i l&#39;ús\n" +
                "de combustibles. Gràcies a la invenció del motor de gasolina es construeixen\n" +
                "els camions, grans vehicles destinats al transport de càrregues.", R.drawable.transport),
        Ambit("Motocicletes catalanes", "Els primers vehicles automòbils de dues rodes tenien moltes similituds en\n" +
                "estructura amb les bicicletes, a les que s’hi afegia diferents tecnologies de\n" +
                "l&#39;època, en especial del motor. La majoria dels models exposats són de la\n" +
                "marca Montesa, fundada per Pere Permanyer l&#39;any 1945, marca líder a la\n" +
                "península Ibèrica durant anys.", R.drawable.motos),
        Ambit("Bombers", "Els cossos de bombers vetllen per la seguretat de la ciutadania i els seus béns.\n" +
                "Antigament, per apagar focs, els antiincendis empraven vehicles arrossegats\n" +
                "per ells mateixos i equipats amb una bomba d&#39;aigua i una mànega d&#39;incendis.\n" +
                "En l&#39;actualitat, els camions apaga focs fan ús de les boques d&#39;aigua del carrer.\n" +
                "Els vehicles que conformen l&#39;àmbit expositiu són una mostra de la col·lecció de\n" +
                "camions i estris que utilitzaven els bombers de Terrassa.", R.drawable.bomberos),
        Ambit("Microcotxes, elèctrics i prototips únics", "El gran nombre vehicles a les ciutats i el nou sorgiment la classe mitjana\n" +
                "genera la necessitat de trobar alternatives menys voluminoses i més\n" +
                "assequibles que els automòbils utilitaris tradicionals. Els microcotxes en són\n" +
                "un exemple: més pràctics gràcies a un volum menor i més econòmics gràcies\n" +
                "al baix cost de producció.\n" +
                "Fruit de la investigació de nous models de cotxes, tenim exemples de\n" +
                "prototips que no van arribar a produir-se, com ara l&#39;automòbil Alfa: turisme de\n" +
                "petites dimensions hagués pogut convertir-se en un utilitari popular als anys\n" +
                "1940-1950, però la manca d&#39;ajuda oficial no va fer efectiva la seva producció.", R.drawable.aviacion),
        Ambit("Automòbils per propulsió elèctrica i per vapor", "La investigació de diferents formes de facilitar el transport de persones i\n" +
                "mercaderies ha afavorit la recerca i la invenció de prototips que s’han allunyat\n" +
                "als automòbils amb motor d’explosió. N’és un bon exemple el Locomobile,\n" +
                "model de gran luxe accionat per propulsió a vapor.\n" +
                "Amb l&#39;arribada de les primeres bateries elèctriques recarregables, al tercer\n" +
                "terç del segle XIX, la indústria va parar especial atenció als cotxes elèctrics. Si\n" +
                "bé actualment són una bona alternativa als motors propulsats per energies\n" +
                "fòssils, antigament presentaven dificultats, relacionats amb la seva\n" +
                "autonomia, potència, entre d’altres.", R.drawable.revolucion),

        )

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)



        cambiarUI()


        //Botón para entrar de la UI de los ámbitos a la de vehículos.
        val botonEntrar: Button = findViewById(R.id.btnOK)

        botonEntrar.setOnClickListener {

            val intent = Intent(this, Vehicle::class.java)
            startActivity(intent)
        }



        val idiomas = listOf("Catalán", "Español", "Inglés")
        val banderas = listOf(R.drawable.bandera_cat, R.drawable.bandera_es, R.drawable.bandera_uk)

        val adapter = SpinnerIdiomas(this, idiomas, banderas)

        val spinner: Spinner = findViewById(R.id.spinnerIdiomas1)
        spinner.adapter = adapter


    }


    //Cambiar la UI de un ámbito a otro.
    private fun cambiarUI() {

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
