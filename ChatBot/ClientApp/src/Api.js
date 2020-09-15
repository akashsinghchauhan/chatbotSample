import axios from 'axios';

const baseUrl = 'https://localhost:44326/api/Visitor/'
export default {

    submitRecords(data) {
        axios.post(baseUrl , data)
            .then((res) => {
                console.log(res.data);
            });
    }

}