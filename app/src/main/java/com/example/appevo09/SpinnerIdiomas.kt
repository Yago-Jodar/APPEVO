package com.example.appevo09

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.ImageView
import android.widget.TextView

class SpinnerIdiomas (context: Context, private val idiomas: List<String>, private val banderas: List<Int>) :
    ArrayAdapter<String>(context, R.layout.spinner_idiomas, idiomas) {

        override fun getView(position: Int, convertView: View?, parent: ViewGroup): View {
            return crearVista(position, parent)
        }

        override fun getDropDownView(position: Int, convertView: View?, parent: ViewGroup): View {
            return crearVista(position, parent)
        }

        private fun crearVista(position: Int, parent: ViewGroup): View {
            val vista = LayoutInflater.from(context).inflate(R.layout.spinner_idiomas, parent, false)

            val banderaImageView: ImageView = vista.findViewById(R.id.banderaImageView)
            banderaImageView.setImageResource(banderas[position]) // Asigna la imagen de la bandera

            val idiomaTextView: TextView = vista.findViewById(R.id.idiomaTextView)
            idiomaTextView.text = idiomas[position]

            return vista
        }
    }
