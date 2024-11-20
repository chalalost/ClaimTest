import { useState } from "react";

    interface IClaim {
        claimId: string,
        customerName: string,
        claimAmount: number,
        claimDes: string,
        claimDate: string,
        claimStatus: string
    }
function ClaimModal() {
    const [claimData, setClaimData] = useState<IClaim>();

    const 
}
export default ClaimModal;