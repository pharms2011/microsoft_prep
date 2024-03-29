import { ShoppingCart } from "@mui/icons-material";
import { AppBar, Badge, Box, IconButton, List, ListItem, Switch, Toolbar, Typography } from "@mui/material";
import { text } from "node:stream/consumers";
import { NavLink } from "react-router-dom";

interface Props {
    toggleDarkMode: () => void;
    isDark: boolean;
}

const midLinks = [
    { title: 'catalog', path: '/catalog' },
    { title: 'about', path: '/about' },
    { title: 'contact', path: '/contact' }
]

const rightLinks = [
    { title: 'login', path: '/login' },
    { title: 'register', path: '/register' }
]

const navStyles = {
    color: 'inherit',
    textDecoration: 'nothing',
    typography: 'h6',
    '&:hover': {
        color: 'secondary.light'
    },
    '&:active': {
        color: 'text.secondary'
    }
}

export default function Header(props: Props) {
    return (
        <>
            <AppBar position='static' sx={{ mb: 4 }}>
                <Toolbar sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                    <Box display='flex' alignItems='center'>
                        <Typography variant='h6' component={NavLink} to='/' sx={{ color: 'inherit', textDecoration: 'none' }}>
                            RE-STORE
                        </Typography>
                        <Switch
                            checked={props.isDark}
                            onChange={props.toggleDarkMode}
                        />
                    </Box>

                    <List sx={{ display: 'flex' }}>
                        {midLinks.map(({ title, path }) => (
                            <ListItem
                                key={title}
                                component={NavLink}
                                to={path}
                                sx={navStyles}
                            >
                                {title.toUpperCase()}
                            </ListItem>
                        ))}
                    </List>
                    <Box display='flex' alignItems='center'>
                        <IconButton size='large' sx={{ color: 'inherit' }}>
                            <Badge badgeContent={4} color='secondary'>
                                <ShoppingCart />
                            </Badge>
                        </IconButton>
                        <List sx={{ display: 'flex' }}>
                            {rightLinks.map(({ title, path }) => (
                                <ListItem
                                    key={title}
                                    component={NavLink}
                                    to={path}
                                    sx={navStyles}
                                >
                                    {title.toUpperCase()}
                                </ListItem>
                            ))}
                        </List>
                    </Box>

                </Toolbar>
            </AppBar>
        </>
    )
} 