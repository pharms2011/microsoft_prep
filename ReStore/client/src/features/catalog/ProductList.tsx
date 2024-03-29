import { Grid } from "@mui/material";
import { Product } from "../../app/models/Product";
import ProductCard from "./ProductCard";

interface Props {
    products: Product[];
}

export default function ProductList({ products }: Props) {
    return (
        //4 here is not pixles, it's based on the theme
        <div className="">
            <Grid container spacing={4}>
                {products.map((item: Product) => (
                    <Grid item xs={3} key={item.id}>
                        <ProductCard product={item} />
                    </Grid>
                )
                )}
            </Grid>
        </div>
    )
}
