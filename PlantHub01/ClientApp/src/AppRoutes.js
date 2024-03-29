import { AllRequests } from "./views/allRequests/AllRequests";
import { CreatePlant } from "./views/createPlant/CreatePlant";
import { Home }  from "./views/home/Home";
import { HowItWorks } from "./views/howItWorks/HowItWorks";
import { Login } from "./views/login/Login";
import { Messages } from "./views/messages/Messages";
import { Profile } from "./views/profile/Profile";
import { RegisterUser } from "./views/registerUser/RegisterUser";
import { SendRequest } from "./views/sendRequest/SendRequest";
import { ViewPlant } from "./views/viewPlant/ViewPlant";

const AppRoutes = [
    {
        path: "/",
        render: (props) => <Home mapsLoaded={props.mapsLoaded} />,
    },
    {
        index: true,
        element: <Home />
    },
    {
        path: "/profile",
        element: <Profile />
    },
    {
        path: "/login",
        element: <Login />
    },
    {
        path: "/register",
        element: <RegisterUser />
    },
    {
        path: "/how-it-works",
        element: <HowItWorks />
    },
    {
        path: "/create-plant",
        element: <CreatePlant />
    },
    {
        path: "/send-request",
        element: <SendRequest />
    },
    {
        path: "/all-requests",
        element: <AllRequests />
    },
    {
        path: "/messages",
        element: <Messages />
    },
    {
        path: "/view-plant",
        element: <ViewPlant />
    }
];
export default AppRoutes;