package com.example.escogervehiculo;

public class CocheAdapter extends RecyclerView.Adapter<CocheAdapter.CocheViewHolder> {
    private List<Coche> coches;

    public CocheAdapter(List<Coche> coches) {
        this.coches = coches;
    }

    public static class CocheViewHolder extends RecyclerView.ViewHolder {
        ImageView imageView;
        TextView textView;

        public CocheViewHolder(View itemView) {
            super(itemView);
            imageView = itemView.findViewById(R.id.imageView);
            textView = itemView.findViewById(R.id.textView);
        }
    }

    @NonNull
    @Override
    public CocheViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_coche, parent, false);
        return new CocheViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull CocheViewHolder holder, int position) {
        Coche coche = coches.get(position);

        // Cargar imagen utilizando Glide o Picasso (debes agregar la dependencia correspondiente)
        Glide.with(holder.imageView.getContext()).load(coche.rutaImagen).into(holder.imageView);

        holder.textView.setText(coche.nombre);
    }

    @Override
    public int getItemCount() {
        return coches.size();
    }
}
