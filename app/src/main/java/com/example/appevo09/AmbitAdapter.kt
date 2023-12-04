package com.example.appevo09

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.ImageView
import android.widget.TextView

class AmbitAdapter (context : Context, val layout : Int, val ambits : MutableList<Ambit> ):
    ArrayAdapter <Ambit> (context, layout, ambits)
{
    override fun getView(position: Int, convertView: View?, parent: ViewGroup): View {

        var view : View

        if (convertView != null){
            view = convertView

        } else {
            view = LayoutInflater.from(getContext()).inflate(layout, parent, false)
        }

        bindAmbit(view, ambits[position])


        return view
    }

    fun bindAmbit(view: View, ambit: Ambit){

        val imgAmbit : ImageView = view.findViewById(R.id.background_image)
        imgAmbit.setImageResource(ambit.image)

        val titlePrincipal : TextView = view.findViewById(R.id.txtTitlePrincipal)
        titlePrincipal.text = ambit.title

        val txtDescription : TextView = view.findViewById(R.id.txtDescription)
        txtDescription.text = ambit.description
    }
}